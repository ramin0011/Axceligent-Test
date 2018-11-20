using System.Collections.Generic;
using System.Linq;

namespace Test6
{
    internal class Building 
    {
        public List<BuildingSection> OrderingSections { get; private set; } = new List<BuildingSection>();
        public List<BuildingSection> BuiltSections { get; private set; } = new List<BuildingSection>();

        public void Build()
        {
            BuiltSections.AddRange(OrderingSections);
            OrderingSections=new List<BuildingSection>();
        }

        public string Describe()
        {
            var res = "";
            if (BuiltSections != null && BuiltSections.Any())
            {
                for (var index = 0; index < BuiltSections.Count; index++)
                {
                    var section = BuiltSections[index];
                    if (section.Type == BuildingProperty.BedRoom)
                        res += $"{section.Name} room";
                    else
                        res += section.Name;

                    if (index != BuiltSections.Count - 1)
                        res += ", ";
                }
            }

            return res;
        }

        public Building AddKitchen()
        {
            OrderingSections.Add(new BuildingSection("kitchen", BuildingProperty.Kitchen));
            return this;
        }

        public Building AddBedroom(string master)
        {
            OrderingSections.Add(new BuildingSection(master, BuildingProperty.BedRoom));
            return this;
        }

        public Building AddBalcony()
        {
            OrderingSections.Add(new BuildingSection("balcony", BuildingProperty.Balcony));
            return this;
        }
    }
}