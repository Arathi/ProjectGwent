using System.Collections.Generic;

namespace Undsf.Gwent.Core.Entity
{
    /// <summary>
    /// 卡组
    /// </summary>
    public class Deck
    {
        /// <summary>
        /// 卡组ID
        /// </summary>
        public int Id { get; set; }
        
        /// <summary>
        /// 玩家信息
        /// </summary>
        public Player Player { get; set; }
        
        /// <summary>
        /// 领袖牌
        /// </summary>
        public int Leader { get; set; }
        
        /// <summary>
        /// 卡牌列表
        /// </summary>
        public IList<int> Cards { get; set; }
    }
}