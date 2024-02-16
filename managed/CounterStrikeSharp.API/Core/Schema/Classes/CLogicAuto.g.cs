// <auto-generated />
#nullable enable
#pragma warning disable CS1591

using System;
using System.Diagnostics;
using System.Drawing;
using CounterStrikeSharp;
using CounterStrikeSharp.API.Modules.Events;
using CounterStrikeSharp.API.Modules.Entities;
using CounterStrikeSharp.API.Modules.Memory;
using CounterStrikeSharp.API.Modules.Utils;
using CounterStrikeSharp.API.Core.Attributes;

namespace CounterStrikeSharp.API.Core;

public partial class CLogicAuto : CBaseEntity
{
    public CLogicAuto (IntPtr pointer) : base(pointer) {}

	// m_OnMapSpawn
	[SchemaMember("CLogicAuto", "m_OnMapSpawn")]
	public CEntityIOOutput OnMapSpawn => Schema.GetDeclaredClass<CEntityIOOutput>(this.Handle, "CLogicAuto", "m_OnMapSpawn");

	// m_OnDemoMapSpawn
	[SchemaMember("CLogicAuto", "m_OnDemoMapSpawn")]
	public CEntityIOOutput OnDemoMapSpawn => Schema.GetDeclaredClass<CEntityIOOutput>(this.Handle, "CLogicAuto", "m_OnDemoMapSpawn");

	// m_OnNewGame
	[SchemaMember("CLogicAuto", "m_OnNewGame")]
	public CEntityIOOutput OnNewGame => Schema.GetDeclaredClass<CEntityIOOutput>(this.Handle, "CLogicAuto", "m_OnNewGame");

	// m_OnLoadGame
	[SchemaMember("CLogicAuto", "m_OnLoadGame")]
	public CEntityIOOutput OnLoadGame => Schema.GetDeclaredClass<CEntityIOOutput>(this.Handle, "CLogicAuto", "m_OnLoadGame");

	// m_OnMapTransition
	[SchemaMember("CLogicAuto", "m_OnMapTransition")]
	public CEntityIOOutput OnMapTransition => Schema.GetDeclaredClass<CEntityIOOutput>(this.Handle, "CLogicAuto", "m_OnMapTransition");

	// m_OnBackgroundMap
	[SchemaMember("CLogicAuto", "m_OnBackgroundMap")]
	public CEntityIOOutput OnBackgroundMap => Schema.GetDeclaredClass<CEntityIOOutput>(this.Handle, "CLogicAuto", "m_OnBackgroundMap");

	// m_OnMultiNewMap
	[SchemaMember("CLogicAuto", "m_OnMultiNewMap")]
	public CEntityIOOutput OnMultiNewMap => Schema.GetDeclaredClass<CEntityIOOutput>(this.Handle, "CLogicAuto", "m_OnMultiNewMap");

	// m_OnMultiNewRound
	[SchemaMember("CLogicAuto", "m_OnMultiNewRound")]
	public CEntityIOOutput OnMultiNewRound => Schema.GetDeclaredClass<CEntityIOOutput>(this.Handle, "CLogicAuto", "m_OnMultiNewRound");

	// m_OnVREnabled
	[SchemaMember("CLogicAuto", "m_OnVREnabled")]
	public CEntityIOOutput OnVREnabled => Schema.GetDeclaredClass<CEntityIOOutput>(this.Handle, "CLogicAuto", "m_OnVREnabled");

	// m_OnVRNotEnabled
	[SchemaMember("CLogicAuto", "m_OnVRNotEnabled")]
	public CEntityIOOutput OnVRNotEnabled => Schema.GetDeclaredClass<CEntityIOOutput>(this.Handle, "CLogicAuto", "m_OnVRNotEnabled");

	// m_globalstate
	[SchemaMember("CLogicAuto", "m_globalstate")]
	public string Globalstate
	{
		get { return Schema.GetUtf8String(this.Handle, "CLogicAuto", "m_globalstate"); }
		set { Schema.SetString(this.Handle, "CLogicAuto", "m_globalstate", value); }
	}

}