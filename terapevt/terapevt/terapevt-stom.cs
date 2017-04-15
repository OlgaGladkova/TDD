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
          "Боль какая? Острая, тупая, приступообразная или постоянная?",
          "Боли когда начинаются? Во время приема пищи, ночью или постоянные?"};
        answer = new string[] {"Предварительный диагноз: ", "Для уточнения диагноза нужно сделать рентген и провести осмотр." };
        diagnosis = new string[]
        {
            "хронический периодонтит.",
            "обострение хронического периодонтита.",
            "периодонтит.",
            "пульпит."
        };
    }

    public string get_question(string ans)
    {
        string ret_question;
        switch (ans)
        {
            case "Здравствуйте": ret_question = question[1]; break;
            case "Да": ret_question = question[2]; break;
            case "Нет": ret_question = "Я вряд ли Вам помогу, обратитесь к другому врачу)"; break;
            case "Острая": ret_question = question[3]; break;
            case "Тупая": ret_question = answer[0] + diagnosis[0] + answer[1]; break;
            case "Приступообразная": ret_question = answer[0] + diagnosis[1] + answer[1]; break;
            case "Постоянная": ret_question = answer[0] + diagnosis[2] + answer[1]; break;
            case "Ночью": ret_question = answer[0] + diagnosis[3] + answer[1]; break;
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
