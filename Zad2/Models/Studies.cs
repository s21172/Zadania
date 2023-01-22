namespace Zad2.Models
{
    public class Studies : IEquatable<Studies>
    {
        public string Name { get; set; }
        public string Mode { get; set; }

        public static HashSet<Studies> uniqueStudies = new();

        public static List<string> uniqueNameStudies = new();

        public Studies(string name, string mode)
        {
            Name = name;
            Mode = mode;
        }

        public override string? ToString()
        {
            return Name + ", Mode: " + Mode;
        }

        public override bool Equals(object obj)
        {
            return this.Equals(obj as Studies);

        }

        public bool Equals(Studies other)
        {
            if (other == null)
                return false;

            return
                 (
                    object.ReferenceEquals(this.Name, other.Name) ||
                    this.Name.Equals(other.Name)
                ) &&
                (
                    object.ReferenceEquals(this.Mode, other.Mode) ||
                    this.Mode.Equals(other.Mode)
                );
        }


        public override int GetHashCode()
        {
            return Name.GetHashCode() ^
                    Mode.GetHashCode(); 
        }

        public static void GetUniqueStudiesNames()
        {
            foreach (var n in uniqueStudies)
            {
                //Console.WriteLine(n);
                uniqueNameStudies.Add(n.Name);
            }
        }
    }
}