﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GyoMetsu.Data
{
    public class EnemyCreator
    {
        public ScriptAPI scriptAPI;

        public EnemyCreator( string scriptPath)
        {
            scriptAPI = new ScriptAPI();
            var script = new Emugen.Script.Script<ScriptAPI>(scriptPath, scriptAPI);
            script.Run();

        }


        public class ScriptAPI
        {
            public string Name;
            public string ImagePath;
            public double ImageScale = 1.0;
            public double ImageSideMargin = 1.0;
            public string DefalutStockElement;
            public int HP = 0;

            public Random Random = new Random();

            public class ActionSkillData
            {
                public string Name;
            }
            public List<ActionSkillData> ActionSkillDatas = new List<ActionSkillData>();
            public List<string> ElementLingPart = new List<string>();
            public Dictionary<string, int> BattleStatusBaseParams = new Dictionary<string, int>();

            public void AddActionSkill(string name)
            {
                var i = new ActionSkillData();
                i.Name = name;

                ActionSkillDatas.Add(i);
            }

            public void AddElementLingPart(string part)
            {
                ElementLingPart.Add(part);
            }

            public void AddStatusBase( string key, int value )
            {
                BattleStatusBaseParams.Add(key, value);
            }
        }
    }
}
