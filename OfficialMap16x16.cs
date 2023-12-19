namespace Milimoe.FunGame.GameMap.OfficialStandard
{
    public class OfficialMap16x16 : Core.Library.Common.Addon.GameMap
    {
        public override string Name => "OfficialMap16x16";

        public override string Description => "宽16格高16格，尺寸为32的地图";

        public override string Version => Core.Library.Constant.FunGameInfo.FunGame_Version;

        public override string Author => Core.Library.Constant.FunGameInfo.FunGame_CopyRight;

        public override float Width => 16;

        public override float Height => 16;

        public override float Size => 32;
    }
}
