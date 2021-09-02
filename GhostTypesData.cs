using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phasmophobia_Ghost_Finding
{
    public static class GhostTypesData
    {
        public static List<GhostTypeModel> GhostTypes = new List<GhostTypeModel>()
        {
            new GhostTypeModel()
            {
                Name_ZH = "魂魄",
                Name_EN = "Spirit",
                Introduction_ZH = "魂魄是最常见的鬼魂，但它仍不容小觑。它通常会在死者死因不明的区域出现。",
                Introduction_EN = "A spirit is the most common Ghost you will come across however it is still very powerful and dangerous. They are usually discovered at one of their hunting grounds after an unexplained death.",
                Unique_Strenths_ZH = "无。",
                Unique_Strenths_EN = "Nothing.",
                Weaknesses_ZH = "在魂魄附近点燃圣木会在一段时间内阻止它的攻击。",
                Weaknesses_EN = "Using Smudge Sticks on a Spirit will stop it attacking for a long period of time.",
                Evidence = new EvidenceModel(true, true, false, false, true, false, false)
            },
            new GhostTypeModel()
            {
                Name_ZH = "死灵",
                Name_EN = "Wraith",
                Introduction_ZH = "死灵是最危险的鬼魂之一。它也是唯一已知的具有飞行能力的鬼魂，有时它还能穿墙。",
                Introduction_EN = "A wraith is one of the most dangerous Ghosts you will find. It is also the only known Ghost that has the ability of flight and has sometimes been known to travel through walls.",
                Unique_Strenths_ZH = "死灵几乎不接触地面，所以它没有足迹。",
                Unique_Strenths_EN = "Wraiths almost never touch the ground meaning it can't be tracked by footsteps.",
                Weaknesses_ZH = "碰触到盐会变得活跃。",
                Weaknesses_EN = "Wraiths have a toxic reaction to Salt.",
                Evidence = new EvidenceModel(true, true, false, false, false, false, true)
            },
            new GhostTypeModel()
            {
                Name_ZH = "幻影",
                Name_EN = "Phantom",
                Introduction_ZH = "幻影是种能附身的鬼魂，通常可用通灵板召唤。它也会让周围的人感到恐惧。",
                Introduction_EN = "A Phantom is a Ghost that can possess the living, most commonly summoned by a Ouija Board. It also induces fear into those around it.",
                Unique_Strenths_ZH = "看见幻影会大幅度降低你的理智。",
                Unique_Strenths_EN = "Looking at a Phantom will considerably drop your sanity.",
                Weaknesses_ZH = "给它拍照会使其暂时消失。",
                Weaknesses_EN = "Taking a photo of the Phantom will make it temporarily disappear.",
                Evidence = new EvidenceModel(false, true, true, false, false, false, true)
            },
            new GhostTypeModel()
            {
                Name_ZH = "骚灵",
                Name_EN = "Poltergeist",
                Introduction_ZH = "鬼魂中最著名的一种鬼，也称为吵闹鬼。它可以通过操纵周围的物体来散播恐惧。",
                Introduction_EN = "One of the most famous Ghosts, a Poltergeist, also known as a noisy ghost can manipulate objects around it to spread fear into it's victims.",
                Unique_Strenths_ZH = "骚灵可以一次性投掷大量物体。",
                Unique_Strenths_EN = "A Poltergeist can throw huge amounts of objects at once.",
                Weaknesses_ZH = "骚灵在空无一物的房间内毫无用处。",
                Weaknesses_EN = "A Poltergeist is almost ineffective in an empty room.",
                Evidence = new EvidenceModel(false, true, true, false, true, false, false)
            },
            new GhostTypeModel()
            {
                Name_ZH = "女妖",
                Name_EN = "Banshee",
                Introduction_ZH = "女妖是天生的猎人，它会攻击任何东西。它只会跟踪一个目标直至其死亡。",
                Introduction_EN = "A Banshee is a natural hunter and will attack anything. It has been known to stalk it's prey one at a time until making it's kill.",
                Unique_Strenths_ZH = "一次只攻击一个人。",
                Unique_Strenths_EN = "A Banshee will only target one person at a time.",
                Weaknesses_ZH = "害怕十字架。",
                Weaknesses_EN = "Banshees fear the Crucifix and will be less aggressive when near one.",
                Evidence = new EvidenceModel(false, false, true, true, false, false, true)
            },
            new GhostTypeModel()
            {
                Name_ZH = "巨灵",
                Name_EN = "Jinn",
                Introduction_ZH = "巨灵是一种地域意识很强的鬼魂，受到威胁时会发动攻击。它能够以相当快的速度移动。",
                Introduction_EN = "A Jinn is a territorial Ghost that will attack when threatened. It has also been known to be able to travel at significant speed.",
                Unique_Strenths_ZH = "如果目标在远处，巨灵会以更快的速度移动。",
                Unique_Strenths_EN = "A Jinn will travel at a faster speed if it's victim is far away.",
                Weaknesses_ZH = "关闭电源可防止巨灵使用技能。",
                Weaknesses_EN = "Turning off the locations power source will prevent the Jinn from using it's ability.",
                Evidence = new EvidenceModel(true, false, true, false, false, true, false)
            },
            new GhostTypeModel()
            {
                Name_ZH = "梦魇",
                Name_EN = "Mare",
                Introduction_ZH = "梦魇是噩梦之源，它是黑暗中最强大的梦魇。",
                Introduction_EN = "A Mare is the source of all nightmares, making it most powerful in the dark.",
                Unique_Strenths_ZH = "梦魇在黑暗中更有可能攻击你。",
                Unique_Strenths_EN = "A Mare will have an increased chance to attack in the dark.",
                Weaknesses_ZH = "开灯会降低它的攻击欲望。",
                Weaknesses_EN = "Turning the lights on around the Mare will lower it's chance to attack.",
                Evidence = new EvidenceModel(false, true, false, true, true, false, false)
            },
            new GhostTypeModel()
            {
                Name_ZH = "亡魂",
                Name_EN = "Revenant",
                Introduction_ZH = "亡魂移动缓慢，但很狂暴，它会肆意攻击。传言道它狩猎时会高速移动。",
                Introduction_EN = "A Revenant is a slow but violent Ghost that will attack indiscriminately. It has been rumoured to travel at a significantly high speed when hunting.",
                Unique_Strenths_ZH = "猎杀时会高速移动。",
                Unique_Strenths_EN = "A Revenant will travel at a significantly faster speed when hunting a victim.",
                Weaknesses_ZH = "找不到猎物时移动缓慢。",
                Weaknesses_EN = "Hiding from the Revenant will cause it to move very slowly.",
                Evidence = new EvidenceModel(false, false, false, true, true, true, false)
            },
            new GhostTypeModel()
            {
                Name_ZH = "暗影",
                Name_EN = "Shade",
                Introduction_ZH = "暗影是个害羞鬼。只要人够多它就不敢活动。",
                Introduction_EN = "A Shade is known to be a Shy Ghost. There is evidence that a Shade will stop all paranormal activity if there are multiple people nearby.",
                Unique_Strenths_ZH = "害羞意味着鬼魂更难被发现。",
                Unique_Strenths_EN = "Being shy means the Ghost will be harder to find.",
                Weaknesses_ZH = "如果附近有多个人，它不会进入狩猎模式。",
                Weaknesses_EN = "The Ghost will not enter hunting mode if there is multiple people nearby.",
                Evidence = new EvidenceModel(true, false, false, false, true, true, false)
            },
            new GhostTypeModel()
            {
                Name_ZH = "恶魔",
                Name_EN = "Demon",
                Introduction_ZH = "恶魔会是你最不想遇到的鬼之一。它会无缘无故地攻击你。",
                Introduction_EN = "A Demon is one of the worst Ghosts you can encounter. It has been known to attack without a reason.",
                Unique_Strenths_ZH = "更具进攻性。",
                Unique_Strenths_EN = "Demons will attack more often then any other Ghost.",
                Weaknesses_ZH = "使用通灵板向恶魔成功提问不会降低你的理智。",
                Weaknesses_EN = "Asking a Demon successful questions on the Ouija Board won't lower the users sanity.",
                Evidence = new EvidenceModel(false, false, true, false, true, true, false)
            },
            new GhostTypeModel()
            {
                Name_ZH = "幽灵",
                Name_EN = "Yurei",
                Introduction_ZH = "幽灵是回到现实世界的复仇之魂。",
                Introduction_EN = "A Yurei is a Ghost that has returned to the physical world, usually for the purpose of revenge or hatred.",
                Unique_Strenths_ZH = "它会让你丧失更多的理智。",
                Unique_Strenths_EN = "Yurei's have been known to have a stronger effect on people sanity.",
                Weaknesses_ZH = "在幽灵的房间里点燃圣木会使它避开这个房间很长时间。",
                Weaknesses_EN = "Smudging the Yurei's room will cause it to not wander around the location for a long time.",
                Evidence = new EvidenceModel(false, false, false, true, false, true, true)
            },
            new GhostTypeModel()
            {
                Name_ZH = "赤鬼",
                Name_EN = "Oni",
                Introduction_ZH = "赤鬼是恶魔的亲戚，拥有超强的力量。传言道它会在猎物周围变得更加活跃。",
                Introduction_EN = "Oni's are a cousin to the Demon and possess extreme strength. There have been rumours that they become more active around their prey.",
                Unique_Strenths_ZH = "当有人在附近时，它会更加活跃。赤鬼也可以高速移动物品。",
                Unique_Strenths_EN = "Oni's are more active when people are nearby and have been seen moving objects at great speed.",
                Weaknesses_ZH = "玩家更活跃会引起赤鬼的兴趣。",
                Weaknesses_EN = "Being more active will make the Oni easier to find and identify.",
                Evidence = new EvidenceModel(true, false, false, false, false, true, true)
            },
            new GhostTypeModel()
            {
                Name_ZH = "寒魔",
                Name_EN = "Hantu",
                Introduction_ZH = "寒魔是一种罕见的鬼魂，它出现在炎热的环境里。它常在寒冷的环境下发起攻击。",
                Introduction_EN = "A rare ghost that can be found in hot climates. They are known to attack more often in cold weather.",
                Unique_Strenths_ZH = "低温会加快寒魔的移速。",
                Unique_Strenths_EN = "Moves faster in colder areas.",
                Weaknesses_ZH = "寒魔在温暖的地方移速较慢。",
                Weaknesses_EN = "Moves slower in warmer areas.",
                Evidence = new EvidenceModel(false, false, true, true, false, true, false)
            },
            new GhostTypeModel()
            {
                Name_ZH = "妖怪",
                Name_EN = "Yokai",
                Introduction_ZH = "妖怪是一种常见的鬼魂，它对人类的声音感兴趣。它通常出没在人类家中。",
                Introduction_EN = "A common type of ghost that is attracted to human voices. They can usually be found haunting family homes.",
                Unique_Strenths_ZH = "在妖怪附近说话会激怒它，增加其攻击欲望。",
                Unique_Strenths_EN = "Talking near a Yokai will anger it and cause it to attack more often.",
                Weaknesses_ZH = "妖怪猎杀时只能听到附近的声音。",
                Weaknesses_EN = "While hunting, it can only hear voices close to it.",
                Evidence = new EvidenceModel(false, true, false, true, false, false, true)
            },
            new GhostTypeModel()
            {
                Name_ZH = "御灵",
                Name_EN = "Goryo",
                Introduction_ZH = "御灵只在通过点阵投影仪时，用摄像机才能看见。",
                Introduction_EN = "Using a video camera is the only way to view a Goryo, when it passes through a DOTS projector.",
                Unique_Strenths_ZH = "御灵通常只在周围没人的情况下才会出现在镜头内。",
                Unique_Strenths_EN = "A Goryo will usually only show itself on camera if there are no people nearby.",
                Weaknesses_ZH = "它很少远离自己的死亡地点。",
                Weaknesses_EN = "They are rarely seen far from their place of death.",
                Evidence = new EvidenceModel(true, false, true, false, false, false, true)
            },
            new GhostTypeModel()
            {
                Name_ZH = "鬼婴",
                Name_EN = "Myling",
                Introduction_ZH = "鬼婴是一种非常健谈和活跃的鬼魂。据说它在猎杀时悄无声息。",
                Introduction_EN = "A Myling is a very vocal and active ghost. They are rumoured to be quiet when hunting their prey.",
                Unique_Strenths_ZH = "无声猎杀。",
                Unique_Strenths_EN = "A Myling is known to be quieter when hunting.",
                Weaknesses_ZH = "鬼婴会更频繁地发出超自然声音。",
                Weaknesses_EN = "Mylings more frequently make paranormal sounds.",
                Evidence = new EvidenceModel(true, false, true, false, true, false, false)
            }
        };
    }
}
