namespace _11._19
{
        
        
    internal class Program
    {      
        /*
         * készíts egy Osztályfőnök osztályt, tulajdonságok: név, OM, van-e osztálya,
         * osztály betűjele, évfolyam száma
         */ 

            //<summary>
            //1. Feladat: Hozz létre egy új osztályt "Student" névvel, a köv tulajdonságokkal
            //név(string)
            //születési (dátum)
            //OM Azonosító (string)
            //Osztály betűjele (string)
            //Évfolyam száma (int)
            //</summary>
            //<param name="args"></param>
        static void Main(string[] args)
        {
            HashSet<Student> students = new HashSet<Student>();
            Student student = new Student("jane doe", null, "123456", "C", 12);
            students.Add(student);
            Student student2 = new Student("john doe", null, "123456", "D", 12);
            students.Add(student2);
            Student student3 = new Student("john biden", null, "123456", "D", 12);
            students.Add(student3);
            Student student4 = new Student("joe biden", null, "123456", "D", 12);
            students.Add(student4);
            /*Console.WriteLine("Aktuális diák lista: ");
            foreach(Student s in students)
            {
                Console.WriteLine(s);
            }*/
            HomeRoomTeacher teacher= new HomeRoomTeacher("Griffin Péter", "123456",true,"C", 12);
            ClassRoom classRoom = new ClassRoom(teacher, "F115", students);
            Console.WriteLine(classRoom.ToString());
            //Console.WriteLine(student.ToString());
            //Console.WriteLine(student2.ToString());
            /*Console.WriteLine(student.isClassMate(student2));
            Console.WriteLine(teacher);
            Console.WriteLine("Is "+teacher.Name+" the homeschool teacher for "+student2.Name+": "+teacher.isTheirHomeRoomTEacher(student2));
            Console.ReadKey();*/
        }
    }
}
