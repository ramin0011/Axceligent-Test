namespace Test3.Models
{
    public class Humanoid
    {
        public Skills.Skill Skill { get; set; }
        public Humanoid(Skills.Skill skill)
        {
            this.Skill = skill;
        }

        public Humanoid()
        {
            
        }

        public string ShowSkill()
        {
            return Skill!=null? this.Skill.ShowSkill(): "no skill is defined";
        }
    }
}
