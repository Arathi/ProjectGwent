using System.Collections.Generic;

namespace Undsf.Gwent.Core.Entity
{
    public class Game
    {
        /// <summary>
        /// 编号
        /// </summary>
        public long Id { get; set; }
        
        /// <summary>
        /// 红方
        /// </summary>
        public Battleground RedSide { get; set; }
        
        /// <summary>
        /// 蓝方
        /// </summary>
        public Battleground BlueSide { get; set; }
        
        /// <summary>
        /// 轮次
        /// </summary>
        public int Round { get; set; }
        
        /// <summary>
        /// 红方分数表
        /// </summary>
        public IList<int> RedScore { get; set; }
        
        /// <summary>
        /// 蓝方分数表
        /// </summary>
        public IList<int> BlueScore { get; set; }
    }
}