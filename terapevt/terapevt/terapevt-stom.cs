using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class terapevt_stom
{
    string[] question, answer, diagnosis;

    public terapevt_stom()
    {
        question = new string[] 
        { "Здравствуйте!",
          "Что Вас беспокоит? Зубная боль?",
          "Боль какая? Острая, тупая, приступообразная или постоянная?" };
        answer = new string[] { "Здравствуйте", "Здравствуйте!" };
        diagnosis = new string[1];
    }

    public string get_question(string ans)
    {
        string ret_question;
        switch (ans)
        {
            case "Здравствуйте": ret_question = question[1]; break;
            case "Да": ret_question = question[2]; break;
            case "нет": ret_question = "Я вряд ли Вам помогу, обратитесь к другому врачу)"; break;
            default:
                ret_question = "Я Вас не понимаю!"; break;
        }
        return ret_question;
    }

    public void visit_a_doctor()
    {
        Console.WriteLine(question[0]);
        string ans = Console.ReadLine();
        while(ans!="")
        {
            Console.WriteLine(get_question(ans));
            ans = Console.ReadLine();
        }

    }

}
