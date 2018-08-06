using System.Collections.Generic;
using Undsf.Gwent.Core.Constant;

namespace Undsf.Gwent.Core.Entity
{
    public class Battleground
    {
        /// <summary>
        /// 玩家信息
        /// </summary>
        public Player Player { get; set; }
        
        /// <summary>
        /// 生命宝石
        /// </summary>
        public int Life { get; set; }
        
        /// <summary>
        /// 弃权标记
        /// </summary>
        public bool Skip { get; set; }
        
        /// <summary>
        /// 阵营
        /// </summary>
        public Camp Camp { get; set; }
        
        /// <summary>
        /// 领袖牌
        /// </summary>
        public int Leader { get; set; }
        
        /// <summary>
        /// 领袖牌是否已经发动
        /// </summary>
        public bool LeaderUsed { get; set; }
        
        /// <summary>
        /// 近战单位
        /// </summary>
        public IList<int> Close { get; set; }
        
        /// <summary>
        /// 远程单位
        /// </summary>
        public IList<int> Ranged { get; set; }
        
        /// <summary>
        /// 攻城单位
        /// </summary>
        public IList<int> Siege { get; set; }
        
        /// <summary>
        /// 手牌
        /// </summary>
        public IList<int> HandCard { get; set; }
        
        /// <summary>
        /// 墓地
        /// </summary>
        public IList<int> Tomb { get; set; }
        
        /// <summary>
        /// 牌堆
        /// </summary>
        public IList<int> Stack { get; set; }
    }
}