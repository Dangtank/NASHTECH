namespace DAY1
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Member> members = new List<Member>{
                new Member{
                    FirstName = "Bui",
                    LastName = "Da",
                    Gender ="Male",
                    DateOfBirth = new DateTime(2001,1,1),
                    PhoneNumber = "0123444333",
                    BirthPlace = "HaNoi",
                     IsGraduated = "No"
                },
                new Member{
                    FirstName = "Anh",
                    LastName = "Tuan",
                    Gender = "Male",
                    DateOfBirth = new DateTime(1999,1,1),
                    PhoneNumber = "0123444555",
                    BirthPlace = "HaNoi",
                    IsGraduated = "Yes"
                },
                new Member{
                    FirstName = "Dat",
                    LastName = "Bui",
                    Gender = "Male",
                    DateOfBirth = new DateTime(2000,1,1),
                    PhoneNumber = "0123444444",
                    BirthPlace = "HaNoi",
                    IsGraduated = "Yes"
                }
            };

            Console.WriteLine("Cau1");
            int max = 0;
            foreach (var member in members)
            {
                if (max < member.Age)
                {
                    max = member.Age;
                }

                if (member.Gender != "Male")
                {
                    continue;
                }

                Console.WriteLine(member.Info);
            }

            Console.WriteLine("Cau2");
            foreach (var member in members)
            {
                if (member.Age == max)
                {
                    Console.WriteLine(member.Info);
                    break;
                }
            }
            Console.WriteLine("Cau3");
            foreach (var member in members)
            {
                Console.WriteLine(member.FullName);
            }

            Console.WriteLine("Cau4");
            List<Member> Age2000 = new List<Member>();
            List<Member> AgeMore2000 = new List<Member>();
            List<Member> AgeLess2000 = new List<Member>();

            foreach (var member in members)
            {
                switch (member.DateOfBirth.Year == 2000)
                {
                    case true:
                        Age2000.Add(member);
                        break;
                    default:
                        switch (member.DateOfBirth.Year < 2000)
                        {
                            case true:
                                AgeLess2000.Add(member);
                                break;
                            default:
                                AgeMore2000.Add(member);
                                break;
                        }
                        break;
                }
            }

            Console.WriteLine("List member birth year is 2000 :");
            foreach (var member in Age2000)
            {
                Console.WriteLine(member.Info);
            }

            Console.WriteLine("List member birth year less 2000 :");
            foreach (var member in AgeLess2000)
            {
                Console.WriteLine(member.Info);
            }

            Console.WriteLine("List member birth year more 2000 :");
            foreach (var member in AgeMore2000)
            {
                Console.WriteLine(member.Info);
            }

            Console.WriteLine("Cau5");
            int flag = 0;
            while (flag < members.Count)
            {
                if (members[flag].BirthPlace == "HaNoi")
                {
                    Console.WriteLine(members[flag].Info);
                    break;
                }
                flag++;
            }
        }
    }
}