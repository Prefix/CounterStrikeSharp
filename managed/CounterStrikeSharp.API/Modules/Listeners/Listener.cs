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

#pragma warning disable CS8604 // Possible null reference argument.
namespace CounterStrikeSharp.API.Modules.Listeners
{
    public abstract class BaseListener
    {
        public string Name { get; private set; }

        public BaseListener(string name)
        {
            if (NativeAPI.CreateListener(name))
            {
                Name = name;
            } else
            {
                throw new Exception($"Listener '{name}' has been already created.");
            }
        }

        public virtual void Execute(params object[] args)
        {
            NativeAPI.ExecuteListener(Name, args);
        }
    }

    public partial class Listener : BaseListener
    {
        public Listener(string name) : base(name)
        {
        }
    }

    public partial class Listener<TArg1> : BaseListener
    {
        public Listener(string name) : base(name)
        {
        }

        public void Execute(TArg1 arg1)
        {
            base.Execute(arg1);
        }
    }

    public partial class Listener<TArg1, TArg2> : BaseListener
    {
        public Listener(string name) : base(name)
        {
        }

        public void Execute(TArg1 arg1, TArg2 arg2)
        {
            base.Execute(arg1, arg2);
        }
    }

    public partial class Listener<TArg1, TArg2, TArg3> : BaseListener
    {
        public Listener(string name) : base(name)
        {
        }

        public void Execute(TArg1 arg1, TArg2 arg2, TArg3 arg3)
        {
            base.Execute(arg1, arg2, arg3);
        }
    }

    public partial class Listener<TArg1, TArg2, TArg3, TArg4> : BaseListener
    {
        public Listener(string name) : base(name)
        {
        }

        public void Execute(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4)
        {
            base.Execute(arg1, arg2, arg3, arg4);
        }
    }

    public partial class Listener<TArg1, TArg2, TArg3, TArg4, TArg5> : BaseListener
    {
        public Listener(string name) : base(name)
        {
        }

        public void Execute(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5)
        {
            base.Execute(arg1, arg2, arg3, arg4, arg5);
        }
    }

    public partial class Listener<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6> : BaseListener
    {
        public Listener(string name) : base(name)
        {
        }

        public void Execute(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6)
        {
            base.Execute(arg1, arg2, arg3, arg4, arg5, arg6);
        }
    }

    public partial class Listener<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7> : BaseListener
    {
        public Listener(string name) : base(name)
        {
        }

        public void Execute(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7)
        {
            base.Execute(arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }
    }

    public partial class Listener<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8> : BaseListener
    {
        public Listener(string name) : base(name)
        {
        }

        public void Execute(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8)
        {
            base.Execute(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
        }
    }

    public partial class Listener<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9> : BaseListener
    {
        public Listener(string name) : base(name)
        {
        }

        public void Execute(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9)
        {
            base.Execute(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
        }
    }

    public partial class Listener<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10> : BaseListener
    {
        public Listener(string name) : base(name)
        {
        }

        public void Execute(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10)
        {
            base.Execute(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
        }
    }

    public partial class Listener<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11> : BaseListener
    {
        public Listener(string name) : base(name)
        {
        }

        public void Execute(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11)
        {
            base.Execute(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
        }
    }

    public partial class Listener<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12> : BaseListener
    {
        public Listener(string name) : base(name)
        {
        }

        public void Execute(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12)
        {
            base.Execute(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
        }
    }

    public partial class Listener<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13> : BaseListener
    {
        public Listener(string name) : base(name)
        {
        }

        public void Execute(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13)
        {
            base.Execute(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
        }
    }

    public partial class Listener<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14> : BaseListener
    {
        public Listener(string name) : base(name)
        {
        }

        public void Execute(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14)
        {
            base.Execute(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
        }
    }

    public partial class Listener<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15> : BaseListener
    {
        public Listener(string name) : base(name)
        {
        }

        public void Execute(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15)
        {
            base.Execute(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
        }
    }

    public partial class Listener<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16> : BaseListener
    {
        public Listener(string name) : base(name)
        {
        }

        public void Execute(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16)
        {
            base.Execute(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
        }
    }
}
#pragma warning restore CS8604 // Possible null reference argument.
