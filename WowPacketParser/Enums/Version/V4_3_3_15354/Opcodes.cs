using WowPacketParser.Misc;

namespace WowPacketParser.Enums.Version.V4_3_3_15354
{
    public static class Opcodes_4_3_3
    {
        public static BiDictionary<Opcode, int> Opcodes()
        {
            return Opcs;
        }

        private static readonly BiDictionary<Opcode, int> Opcs = new BiDictionary<Opcode, int>
        {
            {Opcode.CMSG_ADDON_REGISTERED_PREFIXES, 0x0480},
            {Opcode.CMSG_AREATRIGGER, 0x33A4},
            {Opcode.CMSG_AUTH_SESSION, 0x0A02},
            {Opcode.CMSG_CHAR_ENUM, 0x2161},
            {Opcode.CMSG_CREATURE_QUERY, 0x23ED},
            {Opcode.CMSG_GAMEOBJECT_QUERY, 0x6B65},
            {Opcode.CMSG_GAMEOBJ_USE, 0x7B64},
            {Opcode.CMSG_GOSSIP_HELLO, 0x65AC},
            {Opcode.CMSG_GOSSIP_SELECT_OPTION, 0x2724},
            {Opcode.CMSG_GUILD_BANK_LOG_QUERY, 0x0218},
            {Opcode.CMSG_GUILD_BANK_QUERY_TAB, 0x6F2D},
            {Opcode.CMSG_GUILD_BANK_QUERY_TEXT, 0x0230},
            {Opcode.CMSG_GUILD_BANK_REM_MONEY_WITHDRAW_QUERY, 0x0290},
            {Opcode.CMSG_GUILD_QUERY_RANKS, 0x0255},
            {Opcode.CMSG_GUILD_ROSTER, 0x0274},
            {Opcode.CMSG_GUILD_SET_ACHIEVEMENT_TRACKING, 0x02D1},
            {Opcode.CMSG_ITEM_REFUND_INFO, 0x6FE4},
            {Opcode.CMSG_JOIN_CHANNEL, 0x0520},
            {Opcode.CMSG_LEAVE_CHANNEL, 0x0000},
            {Opcode.CMSG_LF_GUILD_ADD_RECRUIT, 0x0004},
            {Opcode.CMSG_LOAD_SCREEN, 0x3101},
            {Opcode.CMSG_MESSAGECHAT_ADDON_GUILD, 0x0528},
            {Opcode.CMSG_MOVE_FALL_RESET, 0x12D0},
            {Opcode.CMSG_MOVE_FORCE_RUN_SPEED_CHANGE_ACK, 0x1250},
            {Opcode.CMSG_MOVE_NOT_ACTIVE_MOVER, 0x1775},
            {Opcode.CMSG_MOVE_SET_FLY, 0x1BB4},
            {Opcode.CMSG_NPC_TEXT_QUERY, 0x7CA5},
            {Opcode.CMSG_PING, 0x0226},
            {Opcode.CMSG_PLAYED_TIME, 0x68E5},
            {Opcode.CMSG_PLAYER_LOGIN, 0x3320},
            {Opcode.CMSG_QUERY_TIME, 0x3625},
            {Opcode.CMSG_QUESTGIVER_ACCEPT_QUEST, 0x3065},
            {Opcode.CMSG_QUESTGIVER_CHOOSE_REWARD, 0x2BAD},
            {Opcode.CMSG_QUESTGIVER_COMPLETE_QUEST, 0x796D},
            {Opcode.CMSG_QUESTGIVER_QUERY_QUEST, 0x7AED},
            {Opcode.CMSG_QUESTGIVER_STATUS_MULTIPLE_QUERY, 0x77E4},
            {Opcode.CMSG_QUESTGIVER_STATUS_QUERY, 0x6024},
            {Opcode.CMSG_QUESTLOG_REMOVE_QUEST, 0x7665},
            {Opcode.CMSG_READY_FOR_ACCOUNT_DATA_TIMES, 0x2924},
            {Opcode.CMSG_REALM_SPLIT, 0x66AD},
            {Opcode.CMSG_REDIRECTION_AUTH_PROOF,0x0A26},
            {Opcode.CMSG_REQUEST_ACCOUNT_DATA, 0x29A4},
            {Opcode.CMSG_REQUEST_PET_INFO, 0x3EAC},
            {Opcode.CMSG_REQUEST_RAID_INFO, 0x60ED},
            {Opcode.CMSG_RESET_FACTION_CHEAT, 0x0222},
            {Opcode.CMSG_SELL_ITEM, 0x2B25},
            {Opcode.CMSG_SETSHEATHED, 0x2AED},
            {Opcode.CMSG_SET_ACTIONBAR_TOGGLES, 0x74A5},
            {Opcode.CMSG_SET_SELECTION, 0x2325},
            {Opcode.CMSG_SET_VEHICLE_REC_ID_ACK, 0x1310},
            {Opcode.CMSG_SUSPEND_TOKEN, 0x0A06},
            {Opcode.CMSG_TAXINODE_STATUS_QUERY, 0x7E65},
            {Opcode.CMSG_UNREGISTER_ALL_ADDON_PREFIXES, 0x0028},
            {Opcode.CMSG_USE_ITEM, 0x352D},
            {Opcode.CMSG_WARDEN_DATA, 0x0202},
            {Opcode.CMSG_WORLD_STATE_UI_TIMER_UPDATE, 0x39E5},
            {Opcode.CMSG_ZONEUPDATE, 0x3125},
            {Opcode.MSG_GUILD_PERMISSIONS, 0x02BC},
            {Opcode.MSG_MOVE_HEARTBEAT,0x1FF4},
            {Opcode.MSG_MOVE_JUMP, 0x1A10},
            {Opcode.MSG_MOVE_SET_FACING, 0x16B4},
            {Opcode.MSG_MOVE_SET_FLIGHT_SPEED, 0x71C6},
            {Opcode.MSG_MOVE_SET_PITCH, 0x1251},
            {Opcode.MSG_MOVE_SET_RUN_MODE, 0x13F4},
            {Opcode.MSG_MOVE_SET_RUN_SPEED, 0x7004},
            {Opcode.MSG_MOVE_SET_SWIM_BACK_SPEED, 0x3404},
            {Opcode.MSG_MOVE_SET_SWIM_SPEED, 0x70CC},
            {Opcode.MSG_MOVE_SET_WALK_MODE, 0x1B71},
            {Opcode.MSG_MOVE_SET_WALK_SPEED, 0x704C},
            {Opcode.MSG_MOVE_START_ASCEND, 0x17F4},
            {Opcode.MSG_MOVE_START_BACKWARD, 0x1A91},
            {Opcode.MSG_MOVE_START_DESCEND, 0x1355},
            {Opcode.MSG_MOVE_START_FORWARD, 0x1E74},
            {Opcode.MSG_MOVE_START_PITCH_DOWN, 0x1E70},
            {Opcode.MSG_MOVE_START_PITCH_UP, 0x1370},
            {Opcode.MSG_MOVE_START_STRAFE_LEFT, 0x1E51},
            {Opcode.MSG_MOVE_START_STRAFE_RIGHT, 0x1691},
            {Opcode.MSG_MOVE_START_SWIM, 0x1A90},
            {Opcode.MSG_MOVE_START_TURN_LEFT, 0x1B11},
            {Opcode.MSG_MOVE_START_TURN_RIGHT, 0x1AD4},
            {Opcode.MSG_MOVE_STOP, 0x1350},
            {Opcode.MSG_MOVE_STOP_ASCEND, 0x1690},
            {Opcode.MSG_MOVE_STOP_PITCH, 0x1E15},
            {Opcode.MSG_MOVE_STOP_STRAFE, 0x1631},
            {Opcode.MSG_MOVE_STOP_SWIM, 0x1E11},
            {Opcode.MSG_MOVE_STOP_TURN, 0x1331},
            {Opcode.MSG_MOVE_TOGGLE_COLLISION_CHEAT, 0x1AF0},
            {Opcode.MSG_SET_DUNGEON_DIFFICULTY, 0x22ED},
            {Opcode.SMSG_ACCOUNT_DATA_TIMES, 0x622D},
            {Opcode.SMSG_ADDON_INFO, 0x22AD},
            {Opcode.SMSG_ALL_ACHIEVEMENT_DATA, 0x390E},
            {Opcode.SMSG_ATTACKERSTATEUPDATE, 0x306D},
            {Opcode.SMSG_AURA_UPDATE, 0x3A24},
            {Opcode.SMSG_AURA_UPDATE_ALL, 0x7A25},
            {Opcode.SMSG_AUTH_CHALLENGE, 0x0055},
            {Opcode.SMSG_AUTH_RESPONSE, 0x3C84},
            {Opcode.SMSG_BINDPOINTUPDATE, 0x696D},
            {Opcode.SMSG_CALENDAR_SEND_CALENDAR, 0x2125},
            {Opcode.SMSG_CHANNEL_NOTIFY, 0x322D},
            {Opcode.SMSG_CHAR_ENUM, 0x30C6},
            {Opcode.SMSG_CLIENTCACHE_VERSION, 0x306C},
            {Opcode.SMSG_CONTACT_LIST, 0x2D65},
            {Opcode.SMSG_CORPSE_RECLAIM_DELAY, 0x79EC},
            {Opcode.SMSG_CREATURE_QUERY_RESPONSE, 0x6424},
            {Opcode.SMSG_DB_REPLY, 0x2546},
            {Opcode.SMSG_DESTROY_OBJECT, 0x3324},
            {Opcode.SMSG_EMOTE, 0x2525},
            {Opcode.SMSG_EQUIPMENT_SET_LIST, 0x6AED},
            {Opcode.SMSG_FEATURE_SYSTEM_STATUS, 0x7D06},
            {Opcode.SMSG_FORCE_SEND_QUEUED_PACKETS, 0x0015},
            {Opcode.SMSG_GAMEOBJECT_QUERY_RESPONSE, 0x64AC},
            {Opcode.SMSG_GOSSIP_COMPLETE, 0x21AC},
            {Opcode.SMSG_GOSSIP_MESSAGE, 0x7664},
            {Opcode.SMSG_GUILD_EVENT, 0x632D},
            {Opcode.SMSG_GUILD_QUERY_RESPONSE, 0x2BEC},
            {Opcode.SMSG_GUILD_RANK, 0x6D06},
            {Opcode.SMSG_GUILD_ROSTER, 0x350C},
            {Opcode.SMSG_INITIALIZE_FACTIONS, 0x3865},
            {Opcode.SMSG_INITIAL_SPELLS, 0x7364},
            {Opcode.SMSG_INIT_WORLD_STATES, 0x272C},
            {Opcode.SMSG_INSTANCE_DIFFICULTY, 0x1755},
            {Opcode.SMSG_LEARNED_DANCE_MOVES, 0x2CEC},
            {Opcode.SMSG_LOGIN_SETTIMESPEED, 0x6B2D},
            {Opcode.SMSG_LOGIN_VERIFY_WORLD, 0x3EE5},
            {Opcode.SMSG_MESSAGECHAT, 0x2FEC},
            {Opcode.SMSG_MONSTER_MOVE, 0x29A5},
            {Opcode.SMSG_MOTD, 0x3C6D},
            {Opcode.SMSG_MOVE_SET_CAN_FLY, 0x64CE},
            {Opcode.SMSG_NAME_QUERY_RESPONSE, 0x7865},
            {Opcode.SMSG_NPC_TEXT_UPDATE, 0x646C},
            {Opcode.SMSG_PET_NAME_QUERY_RESPONSE, 0x2865},
            //{Opcode.SMSG_PONG, 0x0302},
            {Opcode.SMSG_PONG, 0x0085},
            {Opcode.SMSG_PLAYER_VEHICLE_DATA, 0x27E5},
            {Opcode.SMSG_QUESTGIVER_OFFER_REWARD, 0x7EAC},
            {Opcode.SMSG_QUESTGIVER_QUEST_DETAILS, 0x23E5},
            {Opcode.SMSG_QUESTGIVER_REQUEST_ITEMS, 0x32AD},
            {Opcode.SMSG_QUEST_QUERY_RESPONSE, 0x2AAD},
            {Opcode.SMSG_REALM_SPLIT, 0x7444},
            {Opcode.SMSG_REDIRECT_CLIENT, 0x0855},
            {Opcode.SMSG_SEND_UNLEARN_SPELLS, 0x78AC},
            {Opcode.CMSG_UPDATE_ACCOUNT_DATA, 0x38EC},
            {Opcode.SMSG_SET_PHASE_SHIFT, 0x7104},
            {Opcode.SMSG_SET_PROFICIENCY, 0x7324},
            {Opcode.SMSG_SPELL_GO, 0x6425},
            {Opcode.SMSG_SPELL_START, 0x212D},
            {Opcode.SMSG_TALENTS_INFO, 0x7FA5},
            {Opcode.SMSG_TIME_SYNC_REQ, 0x650E},
            {Opcode.SMSG_TUTORIAL_FLAGS, 0x25A4},
            {Opcode.SMSG_UPDATE_ACCOUNT_DATA,0x7565},
            {Opcode.SMSG_ACTION_BUTTONS, 0x604C},
            {Opcode.SMSG_UPDATE_OBJECT, 0x6264},
            {Opcode.SMSG_UPDATE_WORLD_STATE, 0x60A5},
        };
    }
}
