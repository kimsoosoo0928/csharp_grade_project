using System;

namespace grade_project
{
    
    abstract class Member
    {
        string Id;
        string Password;
        string Name;
        protected bool IsProffessor;

        public Member(string _id, string _password, string _name)
        {
            Id = _id;
            Password = _password;
            Name = _name;
        }

        abstract public void ShowMenu();
    }

    class Professor : Member
    {
        public Professor(string _id, string _password, string _name) : base(_id, _password, _name)
        {
            this.IsProffessor = true;
        }

        public override void ShowMenu()
        {
            throw new NotImplementedException();
        }
    }

    class Student : Member
    {
        public Student(string _id, string _password, string _name) : base(_id, _password, _name)
        {
            this.IsProffessor = false;
        }

        public override void ShowMenu()
        {
            throw new NotImplementedException();
        }
    }

    class Program
    {

        // 로그인 메서드 만들기
        private static void Login()
        {
            Console.WriteLine("");
            Console.WriteLine("==로그인==");
            Console.WriteLine("");
            Console.Write("ID를 입력하세요 : ");
            string id = Console.ReadLine();
            Console.Write("PW를 입력하세요 : ");
            string pw = Console.ReadLine();
            Console.WriteLine(id + "님,반갑습니다.");

            // login한 정보를 어떻게 회원가입 정보와 일시시켜서 로그인 유무를 가능 하게 할까?


        }

        private static void Join()
        {
           
            Console.WriteLine("");
            Console.WriteLine("==회원가입==");
            Console.WriteLine("");
            Console.Write("이름를 입력하세요 : ");
            string name = Console.ReadLine();            
            Console.Write("ID를 입력하세요 : ");            
            string id = Console.ReadLine();
            Console.Write("PW를 입력하세요 : ");
            string pw = Console.ReadLine();
            Console.Write("교수면 1, 학생이면 0 을 입력하세요 : ");
            bool job = bool.TryParse(Console.ReadLine(), out job);
            Console.WriteLine("");

            // 회원가입한것에 대한 정보를 어딘가 저장해놓고 로그인할때 가져와야 할텐데 그건 어떻게 할까? 

        }

        static void Write_point()
        {
            int kor;
            int eng;
            int math;
            Console.Write("국어점수를 입력하세요 : ");
            int.TryParse(Console.ReadLine(), out kor);
            Console.Write("영어점수를 입력하세요 : ");
            int.TryParse(Console.ReadLine(), out eng);
            Console.Write("수학점수를 입력하세요 : ");
            int.TryParse(Console.ReadLine(), out math);

        }

        static void Check_grade()
        {
            
        }

        static void Logout()
        {

        }

        static void Menu_prof() 
        {
            while (true)
            {
                Console.WriteLine("");
                Console.WriteLine("1. 성적 기입");
                Console.WriteLine("2. 성적 확인");
                Console.WriteLine("3. 로그아웃");
                Console.WriteLine("4. 프로그램 종료");
                Console.WriteLine("");
                Console.Write("메뉴를 입력하세요 : ");
               
                int menu;
                int.TryParse(Console.ReadLine(), out menu);
                
                if (menu == 1)
                {
                    Write_point();
                }
                else if (menu == 2)
                {
                    Check_grade();
                }
                else if (menu == 3)
                {
                    Logout();
                }
                else
                {
                    mainLoop = false;
                    break;
                }                       
                
               
            }
        }

        static void Menu_student()
        {
            while (true)
            {
                Console.WriteLine("");                
                Console.WriteLine("1. 성적 확인");
                Console.WriteLine("2. 로그아웃");
                Console.WriteLine("3. 프로그램 종료");
                Console.WriteLine("");
                Console.Write("메뉴를 입력하세요 : ");

                int menu;
                int.TryParse(Console.ReadLine(), out menu);

                if (menu == 1)
                {
                    Check_grade();
                }
                else if (menu == 2)
                {
                    Logout();
                }
                else
                {
                    mainLoop = false;
                    break;
                }


            }
        }

        static bool mainLoop = true;

        static void Main(string[] args)
        {

            Professor professor = new Professor("","","");

            while (mainLoop)
            {
                Console.WriteLine("==학사관리 프로그램==");
                Console.WriteLine("");
                Console.WriteLine("1. 교수 로그인");
                Console.WriteLine("2. 학생 로그인");
                Console.WriteLine("3. 회원가입");
                Console.WriteLine("4. 프로그램종료");
                Console.WriteLine("");
                Console.Write("메뉴를 입력하세요 : ");


                int menu;
                int.TryParse(Console.ReadLine(), out menu);
                //menu = Convert.ToInt32(Console.ReadLine()); 이렇게는 사용안한다.

                if (menu == 1)
                {

                    Login();

                    Menu_prof();

                }

                else if (menu == 2)
                {
                    Login();

                    Menu_student();
                }

                else if (menu == 3)
                {
                    Join();
                    
                }

                else
                {
                    Console.Write("=프로그램종료=");
                    mainLoop = false;
                }
            }


        }








    }





}
