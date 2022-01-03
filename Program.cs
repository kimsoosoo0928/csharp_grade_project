using System;

namespace grade_project
{
    class Program
    {

        // 로그인 메서드 만들기
        private static void Login()
        {
            
            Console.WriteLine("==로그인==");
            Console.Write("ID를 입력하세요 : ");
            string id = Console.ReadLine();
            Console.Write("PW를 입력하세요 : ");
            string pw = Console.ReadLine();
            Console.WriteLine(id + "님,반갑습니다.");
            
            
            
        }

        private static void Join()
        {
            Console.WriteLine("==회원가입==");
            Console.Write("이름를 입력하세요 : ");
            string name = Console.ReadLine();
            Console.Write("ID를 입력하세요 : ");
            string id = Console.ReadLine();
            Console.Write("PW를 입력하세요 : ");
            string pw = Console.ReadLine();
            

        }


        static void Main(string[] args)
        {
            
            {
                Console.WriteLine("==학사관리 프로그램==");
                Console.WriteLine("1. 로그인");
                Console.WriteLine("2. 회원가입");
                Console.WriteLine("3. 프로그램종료");
                Console.Write("메뉴를 입력하세요 : ");


                int menu;
                 menu = Convert.ToInt32(Console.ReadLine()); 

                if(menu==1)
                {
                   
                        Login();
                                
                }
                 
                else if (menu==2)
                {
                    Join();
                }    
                else
                {
                    Console.Write("=프로그램종료=");
                }
                }

                    
               
                
                
        
                
            }
        }

        
        


    }
