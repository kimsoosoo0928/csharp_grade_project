using System;

namespace grade_project
{
    class Program
    {

        // 로그인 메서드 만들기
        public void Login(string name, string id, string password)
        {
            
            Console.WriteLine("이름을 입력하세요.");
            name = Console.ReadLine();
            Console.WriteLine("ID을 입력하세요.");
            id = Console.ReadLine();
            Console.WriteLine("PASSWORD를 입력하세요.");
            password = Console.ReadLine();
            
        }
        
   
        static void Main(string[] args)
        {
            
            {
                Console.WriteLine("==학사관리 프로그램==");
                Console.WriteLine("1. 로그인");
                Console.WriteLine("2. 회원가입");
                Console.WriteLine("3. 프로그램종료");
                
                string input = Console.ReadLine();

                if (input == "1")
                {
                    
                }

                    
               
                
                
        
                
            }
        }

        
        


    }
}