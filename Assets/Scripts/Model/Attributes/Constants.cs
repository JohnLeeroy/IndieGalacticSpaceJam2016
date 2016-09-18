using UnityEngine;
using System.Collections;

public abstract class Constants {
	public const int COST_TYPE_FUEL = 0;
	public const int COST_TYPE_MATERIALS = 1;
	public const int COST_TYPE_SELLABLE = 2;

	public const int SILO_TYPE_ID = 0;
	public const int SOLAR_COLLECTOR_TYPE_ID = 1;
	public const int ROBOT_FACTORY_TYPE_ID = 2;
	public const int LAUNCH_PAD_TYPE_ID = 3;
	public const int DRILL_TYPE_ID = 4;

	public const int CLICK_VALUE_UPGRADE_ID = 5;
	public const int DRILL_MORE_ORE_UPGRADE_ID = 6;
	public const int DRILL_LESS_SPACE_UPGRADE_ID = 7;

	public const int SILO_MORE_CAPACITY_UPGRADE_ID = 8;
	public const int SILO_LESS_SPACE_UPGRADE_ID = 9;

	public const int LAUNCHPAD_LARGER_PAYLOAD_CAPACITY_UPGRADE_ID = 10;
	public const int LAUNCHPAD_LESS_SPACE_UPGRADE_ID = 11;
	public const int LAUNCHPAD_LOWER_FUEL_COST_UPGRADE_ID = 12;
	public const int LAUNCHPAD_LOWER_PRICE_UPGRADE_ID = 13;

	public const int ROBOT_FACILITY_MORE_ROBOTS_UPGRADE_ID = 14;
	public const int ROBOT_FACILITY_LESS_SPACE_UPGRADE_ID = 15;

	public const int SOLAR_FARM_MORE_POWER_UPGRADE_ID = 16;
	public const int SOLAR_FARM_LESS_SPACE_UPGRADE_ID = 17;
	public const int UPGRADE_ID_END = 18;
}
