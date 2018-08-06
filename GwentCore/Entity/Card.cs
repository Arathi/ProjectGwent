using Undsf.Gwent.Core.Constant;

namespace Undsf.Gwent.Core.Entity
{
    public class Card
    {
        /// <summary>
        /// 卡牌ID
        /// </summary>
        public int Id { get; set; }
        
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// 分类
        /// </summary>
        public CardType Type { get; set; }
        
        /// <summary>
        /// 攻击力
        /// </summary>
        public int Attack { get; set; }
        
        /// <summary>
        /// 位置
        /// </summary>
        public Position Position { get; set; }
        
        /// <summary>
        /// 阵营
        /// </summary>
        public Camp Camp { get; set; }
        
        /// <summary>
        /// 特殊能力
        /// </summary>
        public Ability Ability { get; set; }
        
        /// <summary>
        /// 描述
        /// </summary>
        public string Description { get; set; }
    }
}