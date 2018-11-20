namespace Test6
{
    class BuildingSection
    {
        public BuildingSection(string name, BuildingProperty type)
        {
            this.Name = name;
            this.Type = type;
        }
        public string Name { get; set; }
        public BuildingProperty Type { get; set; }
    }
}