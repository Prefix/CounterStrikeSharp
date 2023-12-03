/*
 *  This file is part of CounterStrikeSharp.
 *  CounterStrikeSharp is free software: you can redistribute it and/or modify
 *  it under the terms of the GNU General Public License as published by
 *  the Free Software Foundation, either version 3 of the License, or
 *  (at your option) any later version.
 *
 *  CounterStrikeSharp is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU General Public License for more details.
 *
 *  You should have received a copy of the GNU General Public License
 *  along with CounterStrikeSharp.  If not, see <https://www.gnu.org/licenses/>. *
 */

#include "scripting/callback_manager.h"
#include "scripting/autonative.h"
#include "scripting/script_engine.h"
#include "core/log.h"

namespace counterstrikesharp {

static bool AddListener(ScriptContext &script_context) {
    auto name = script_context.GetArgument<const char *>(0);
    auto callback = script_context.GetArgument<CallbackT>(1);

    return globals::callbackManager.TryAddFunction(name, callback);
}

static bool RemoveListener(ScriptContext &script_context) {
    auto name = script_context.GetArgument<const char *>(0);
    auto callback = script_context.GetArgument<CallbackT>(1);

    return globals::callbackManager.TryRemoveFunction(name, callback);
}

static bool CreateListener(ScriptContext& script_context) {
    auto name = script_context.GetArgument<const char*>(0);
    CSSHARP_CORE_INFO("CreateListener: {}", name);

    if (globals::callbackManager.FindCallback(name) == nullptr)
    {
        globals::callbackManager.CreateCallback(name);
        return true;
    }

    return false;
}

static bool DeleteListener(ScriptContext& script_context) {
    auto name = script_context.GetArgument<const char*>(0);
    CSSHARP_CORE_INFO("DeleteListener: {}", name);
    ScriptCallback* callback = globals::callbackManager.FindCallback(name);

    if (callback != nullptr) {
        globals::callbackManager.ReleaseCallback(callback);
        return true;
    }

    return false;
}

static void ExecuteListener(ScriptContext& script_context) {
    auto name = script_context.GetArgument<const char*>(0);

    ScriptCallback* callback = globals::callbackManager.FindCallback(name);

    if (callback == nullptr)
    {
        CSSHARP_CORE_ERROR("Tried to execute invalid listener '{}'", name);
        return;
    }

    CSSHARP_CORE_TRACE("ExecuteListener: {}", name);
    int argumentCount = script_context.GetArgumentCount();

    if (argumentCount > script_context.MaxArguments) {
        CSSHARP_CORE_ERROR("Passing more than {} parameters to a function is not supported", script_context.MaxArguments);
        return;
    }

    if (callback && callback->GetFunctionCount()) {
        callback->ScriptContext().Reset();

        for (int i = 1; i < argumentCount; i++)
        {
            CSSHARP_CORE_TRACE("Pushing {}", script_context.GetArgument<void*>(i));
            callback->ScriptContext().Push(script_context.GetArgument<void*>(i));
        }

        callback->Execute();
    }
}

REGISTER_NATIVES(callbacks, {
    ScriptEngine::RegisterNativeHandler("ADD_LISTENER", AddListener);
    ScriptEngine::RegisterNativeHandler("REMOVE_LISTENER", RemoveListener);
    ScriptEngine::RegisterNativeHandler("CREATE_LISTENER", CreateListener);
    ScriptEngine::RegisterNativeHandler("DELETE_LISTENER", DeleteListener);
    ScriptEngine::RegisterNativeHandler("EXECUTE_LISTENER", ExecuteListener);
})
}  // namespace counterstrikesharp
