using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseRegistrationSystem.EFClasses;

namespace CourseRegistrationSystem
{
    class DBSeed
    {
        private static CourseRegistrationEntities context;

        public static void Seed()
        {

            // Add data to the database

            context = new CourseRegistrationEntities();
            context.Database.Log = s => Debug.Write(s);

            List<Student> students = new List<Student>()
            {
                new Student {StudentName = "Marvin Rao"},
                new Student {StudentName="Jay Choi"},
                new Student {StudentName="Angella Bell"},
                new Student {StudentName="Maple Chay"},
                new Student {StudentName="Virat Kohli"},
                new Student {StudentName="Jerry Karmer"},
                new Student {StudentName="Ringo Dugg"},
                new Student {StudentName="Elain Liu"},
                new Student {StudentName="Marc Henry"},
                new Student {StudentName="Rusev Padukone"},
                new Student {StudentName="Priyanka Sharma"},
                new Student {StudentName="Mikhail Serebriakov"},
                new Student {StudentName="Rohit Jha"},
                new Student {StudentName="Peter Lee"},
                new Student {StudentName="Joe Kim"},
                new Student {StudentName="David Letty"},
                new Student {StudentName="Joh Mfume"},
                new Student {StudentName="Halet Martifem"},
                new Student {StudentName="Merilyn Johmson"},
                new Student {StudentName="Johnathan Edwards"},
                new Student {StudentName="John Chin"},
                new Student {StudentName="Janice Greenwald"},
                new Student {StudentName="Mary Parker"},
                new Student {StudentName="Deborah Wood"},
                new Student {StudentName="Neena Kochhar"},
                new Student {StudentName="Bruce Ernst"},
                new Student {StudentName="David Austin"},
                new Student {StudentName="Alexender Hunold"},
                new Student {StudentName="Lex Han"},
                new Student {StudentName="Eshley Peterson"},
                new Student {StudentName="Eve James"},
                new Student {StudentName="Roman Nash"},
                new Student {StudentName="Joy Smith"},
                new Student {StudentName="Sahar Graham"},
                new Student {StudentName="Sarah Russel"},
                new Student {StudentName="Jannet Walton"},
                new Student {StudentName="Sohia Wilson"},
                new Student {StudentName="Tia Robitaille"},
                new Student {StudentName="John Oliver"},
                new Student {StudentName="George Jacob"},
                new Student {StudentName="Edward Muhammad"},
                new Student {StudentName="Albert Henry"},
                new Student {StudentName="Annie Lilly"},
                new Student {StudentName="Ethel Sienna"},
                new Student {StudentName="Stephen Logan"},
                new Student {StudentName="Paul Issac"},
                new Student {StudentName="James Joseph"},
                new Student {StudentName="Richard Noah"},
                new Student {StudentName="Daniel Frank"},
                new Student {StudentName="Peter Ethan"},
                new Student {StudentName="Henry Oscar"},
                new Student {StudentName="Joshua Arthar"},
                new Student {StudentName="Sunidhi Luis"},
                new Student {StudentName="Nimitha Trivedi"},
                new Student {StudentName="Naveen Kumar"},
                new Student {StudentName="June Wilson"},
                new Student {StudentName="April Goslin"},
                new Student {StudentName="Mhaveneh Sohal"},
                new Student {StudentName="Rajat Mangal"},
                new Student {StudentName="Gurman Singh"},
                new Student {StudentName="Rajan Kambhoj"},
                new Student {StudentName="Vasu Dhir"},
                new Student {StudentName="Supriya Verma"},
                new Student {StudentName="David Adley"},
                new Student {StudentName="Harry Branson"},
                new Student {StudentName="Puneet Bristol"},
                new Student {StudentName="Herbert Kelsey"},
                new Student {StudentName="Corliss Marley"},
                new Student {StudentName="Johnathan Enfield"},
                new Student {StudentName="Johnathan Dudley"},
                new Student {StudentName="Johnathan Alby"},
                new Student {StudentName="Aiken Kilton"},
                new Student {StudentName="Arlo Marklov"},
                new Student {StudentName="Brune Hayley"},
                new Student {StudentName="Brook Huskley"},
                new Student {StudentName="Ivy Clobe"},
                new Student {StudentName="Rock Clive"},
                new Student {StudentName="Nick Raydon"},
                new Student {StudentName="Barnett Lindsey"},
                new Student {StudentName="Alvin Kirby"},
                new Student {StudentName="Nelson Milton"},
                new Student {StudentName="Reza Darbey"},
                new Student {StudentName="Ravi Peyton"},
                new Student {StudentName="John Compton"},
                new Student {StudentName="Rusev Ramsey"},
                new Student {StudentName="Sophie Clare"},
                new Student {StudentName="Lily Morton"},
                new Student {StudentName="William Oakes"},
                new Student {StudentName="Amelia Norton"},
                new Student {StudentName="Isla Clinton"},
                new Student {StudentName="Murphy Coombs"},
                new Student {StudentName="Davis Brixton"},
                new Student {StudentName="Rees Pery"},
                new Student {StudentName="Joe Langston"},
                new Student {StudentName="Gilbert Farley"},
                new Student {StudentName="priya Ainsley"},
                new Student {StudentName="Jannat Gladstone"},
                new Student {StudentName="Raymond Goody"},
                new Student {StudentName="Stephen Fawcett"},
                new Student {StudentName="Mehmood Everley"}
            };

            List<Instructor> instructors = new List<Instructor>()
            {
                 new Instructor{InstructorName="Xing Liu"},
                 new Instructor{InstructorName="Michael Ma"},
                 new Instructor{InstructorName="Michael Hrybyk"},
                 new Instructor{InstructorName="Stephen Chiong"},
                 new Instructor{InstructorName="Simon Lee"},
                 new Instructor{InstructorName="Padmapriya Kandhadhai"},
                 new Instructor{InstructorName="Gilbert Tsui"},
                 new Instructor{InstructorName="Nelson Eng"},
                 new Instructor{InstructorName="Reza Abassi"},
                 new Instructor{InstructorName="Gabriel Vitus"},
                 new Instructor{InstructorName="Michael Wufka"},
                 new Instructor{InstructorName="Sayeed Mirjalili"},
                 new Instructor{InstructorName="Malakka Walpola"},
                 new Instructor{InstructorName="Mehwish Basir"},
                 new Instructor{InstructorName="Anupama Devi"},
                 new Instructor{InstructorName="Raymond Yu"},
                 new Instructor{InstructorName="Raheem Virani"},
                 new Instructor{InstructorName="Kimberley Alclok"},
                 new Instructor{InstructorName="Aliabeth Ardene"},
                 new Instructor{InstructorName="Jennifer Arfer"},
                 new Instructor{InstructorName="Diana Betty"},
                 new Instructor{InstructorName="Lorrie Bogden"},
                 new Instructor{InstructorName="Stacey Cap"},
                 new Instructor{InstructorName="Laura Cardoso"},
                 new Instructor{InstructorName="John Carter"},
                 new Instructor{InstructorName="Phillip Chan"},
                 new Instructor{InstructorName="Steve Charlton"},
                 new Instructor{InstructorName="Edward Choi"},
                 new Instructor{InstructorName="Jenn Fane"},
                 new Instructor{InstructorName="Alida Faurie"},
                 new Instructor{InstructorName="Fixton Brian"},
                 new Instructor{InstructorName="Tanvir Gill"},
                 new Instructor{InstructorName="Richard Wong"},
                 new Instructor{InstructorName="Gladish Liu"}
            };

            List<Department> departments = new List<Department>()
            {
                new Department {    DepartmentCode="CSIS", DepartmentName="Computer Science"    },
                new Department {    DepartmentCode="ECON", DepartmentName="Economics"    },
                new Department {    DepartmentCode="MARK", DepartmentName="Marketing"    },
                new Department {    DepartmentCode="ACCT", DepartmentName="Accounting"    },
                new Department {    DepartmentCode="BUSN", DepartmentName="Business"    },
                new Department {    DepartmentCode="FINC", DepartmentName="Finance"    },
                new Department {    DepartmentCode="HOSP", DepartmentName="Hospitality Management"    },
                new Department {    DepartmentCode="OADM", DepartmentName="Office Administration"    }
            };

            List<Course> courses = new List<Course>()
            {
                new Course{     DepartmentCode="ACCT", CourseNumber=1110, CourseTitle="Principles of Accounting I"},
                new Course{     DepartmentCode="ACCT", CourseNumber=1210, CourseTitle="Principles of Accounting II"},
                new Course{     DepartmentCode="ACCT", CourseNumber=1222, CourseTitle="Computer Applications for Accounting"},
                new Course{     DepartmentCode="ACCT", CourseNumber=1235, CourseTitle="Principles of Introductory Financial Accounting I & II"},
                new Course{     DepartmentCode="BUSN", CourseNumber=1005, CourseTitle="Business Law Fundamentals for Accountants"},
                new Course{     DepartmentCode="BUSN", CourseNumber=1200, CourseTitle="Fundamentals of Business"},
                new Course{     DepartmentCode="BUSN", CourseNumber=1320, CourseTitle="Introductory Business Law"},
                new Course{     DepartmentCode="BUSN", CourseNumber=2290, CourseTitle="Introduction to Quantitative Decision Making"},
                new Course{     DepartmentCode="BUSN", CourseNumber=3200, CourseTitle="Global Trade Finance"},
                new Course{     DepartmentCode="CSIS", CourseNumber=1175, CourseTitle="Introduction to Programming I"},
                new Course{     DepartmentCode="CSIS", CourseNumber=1190, CourseTitle="Excel for Business"},
                new Course{     DepartmentCode="CSIS", CourseNumber=1275, CourseTitle="Introduction to Programming II"},
                new Course{     DepartmentCode="CSIS", CourseNumber=1280, CourseTitle="Multimedia Web Development"},
                new Course{     DepartmentCode="CSIS", CourseNumber=2260, CourseTitle="Operating Systems"},
                new Course{     DepartmentCode="CSIS", CourseNumber=2270, CourseTitle="Virtualization and Computer Networking"},
                new Course{     DepartmentCode="CSIS", CourseNumber=2300, CourseTitle="Database I"},
                new Course{     DepartmentCode="CSIS", CourseNumber=3155, CourseTitle="Network Security"},
                new Course{     DepartmentCode="CSIS", CourseNumber=3175, CourseTitle="Introduction to Mobile Application Development"},
                new Course{     DepartmentCode="CSIS", CourseNumber=3190, CourseTitle="Business Support Systems with Excel"},
                new Course{     DepartmentCode="CSIS", CourseNumber=3270, CourseTitle="Advanced Networking"},
                new Course{     DepartmentCode="CSIS", CourseNumber=3275, CourseTitle="Software Engineering"},
                new Course{     DepartmentCode="CSIS", CourseNumber=3280, CourseTitle="Web Based Scripting"},
                new Course{     DepartmentCode="CSIS", CourseNumber=3300, CourseTitle="Database II"},
                new Course{     DepartmentCode="CSIS", CourseNumber=3360, CourseTitle="Fundamentals of Data Analytics"},
                new Course{     DepartmentCode="CSIS", CourseNumber=3375, CourseTitle="UX Design in Mobile Applications"},
                new Course{     DepartmentCode="CSIS", CourseNumber=3380, CourseTitle="Advanced Web Programming With JavaScript & AJAX"},
                new Course{     DepartmentCode="CSIS", CourseNumber=3475, CourseTitle="Data Structures & Algorithms"},
                new Course{     DepartmentCode="CSIS", CourseNumber=3540, CourseTitle="Client Server Systems"},
                new Course{     DepartmentCode="CSIS", CourseNumber=3860, CourseTitle="Data Visualization"},
                new Course{     DepartmentCode="CSIS", CourseNumber=4175, CourseTitle="Mobile Application Development II"},
                new Course{     DepartmentCode="CSIS", CourseNumber=4260, CourseTitle="Special Topics in Data Analytics"},
                new Course{     DepartmentCode="CSIS", CourseNumber=4270, CourseTitle="Cloud Infrastructure"},
                new Course{     DepartmentCode="CSIS", CourseNumber=4280, CourseTitle="Special Topics in Web/Mobile Application Development"},
                new Course{     DepartmentCode="ECON", CourseNumber=2350, CourseTitle="Managerial Economics"},
                new Course{     DepartmentCode="ECON", CourseNumber=1150, CourseTitle="Principles of Microeconomics"},
                new Course{     DepartmentCode="ECON", CourseNumber=1250, CourseTitle="Principles of Macroeconomics"},
                new Course{     DepartmentCode="FINC", CourseNumber=1231, CourseTitle="Business Mathematics"},
                new Course{     DepartmentCode="FINC", CourseNumber=2300, CourseTitle="Personal Finance I"},
                new Course{     DepartmentCode="HOSP", CourseNumber=1115, CourseTitle="Tourism Business Structure"},
                new Course{     DepartmentCode="HOSP", CourseNumber=1145, CourseTitle="Introductory Food Management"},
                new Course{     DepartmentCode="HOSP", CourseNumber=1210, CourseTitle="Accounting Principles"},
                new Course{     DepartmentCode="HOSP", CourseNumber=2240, CourseTitle="Front Desk Operations"},
                new Course{     DepartmentCode="HOSP", CourseNumber=2310, CourseTitle="Hospitality Management Accounting	"},
                new Course{     DepartmentCode="MARK", CourseNumber=1120, CourseTitle="Introductory Marketing"},
                new Course{     DepartmentCode="MARK", CourseNumber=3215, CourseTitle="Buyer Behaviour"},
                new Course{     DepartmentCode="MARK", CourseNumber=3220, CourseTitle="Marketing Essentials for Employment Supports Specialty"},
                new Course{     DepartmentCode="MARK", CourseNumber=3235, CourseTitle="E-Marketing"},
                new Course{     DepartmentCode="OADM", CourseNumber=1114, CourseTitle="Anatomy, Physiology and Medical Terminology"},
                new Course{     DepartmentCode="OADM", CourseNumber=1151, CourseTitle="Medical Administrative Procedures"},
                new Course{     DepartmentCode="OADM", CourseNumber=1214, CourseTitle="Anatomy, Physiology & Medical Terminology II"},
                new Course{     DepartmentCode="OADM", CourseNumber=1218, CourseTitle="Legal Office Procedures – Introduction and Corporate Law"},
                new Course{     DepartmentCode="OADM", CourseNumber=1240, CourseTitle="Business Communications and Procedures"}
            };

            context.Students.AddRange(students);
            context.Instructors.AddRange(instructors);
            context.Departments.AddRange(departments);
            context.Courses.AddRange(courses);

            context.SaveChanges();
        }
       
    }
}
