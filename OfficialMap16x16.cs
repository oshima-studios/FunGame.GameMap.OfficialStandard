namespace Milimoe.FunGame.GameMap.OfficialStandard
{
    public class OfficialMap16x16 : Core.Library.Common.Addon.GameMap
    {
        public override string Name => "OfficialMap16x16";

        public override string Description => "长16格，宽16格，高16格，尺寸为32的立方体地图";

        public override string Version => Core.Library.Constant.FunGameInfo.FunGame_Version;

        public override string Author => Core.Library.Constant.FunGameInfo.FunGame_CopyRight;

        public override float Length => 16;
        
        public override float Width => 16;

        public override float Height => 16;

        public override float Size => 32;
    }
}
