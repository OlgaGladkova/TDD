﻿using System;
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
          "Боли когда начинаются? Во время приема пищи, ночью или постоянные?",
          "При каждом приеме пищи или при употреблении холодного / горячего / сладкого / кислого?"
        };
        answer = new string[] {"Предварительный диагноз: ", "Для уточнения диагноза нужно сделать рентген и провести осмотр." };
        diagnosis = new string[]
        {
            "хронический периодонтит.",
            "обострение хронического периодонтита.",
            "периодонтит.",
            "пульпит.",
            "глубокий кариес.",
            "средний кариес.",
            "очаговый пульпит.",
            "диффузный пульпит."
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
            case "Постоянные":
            case "Постоянная": ret_question = answer[0] + diagnosis[2] + answer[1]; break;
            case "Ночью": ret_question = answer[0] + diagnosis[3] + answer[1]; break;
            case "Во время приема пищи":
            case "Во время еды": ret_question = question[4]; break;
            case "Каждый прием":
            case "Каждый прием пищи": 
            case "При каждом прием пищи": ret_question = answer[0] + diagnosis[4] + answer[1]; break;
            case "При употреблении холодного":
            case "При употреблении сладкого": ret_question = answer[0] + diagnosis[5] + answer[1]; break;
            case "При употреблении горячего": ret_question = answer[0] + diagnosis[6] + answer[1]; break;
            case "При употреблении кислого": ret_question = answer[0] + diagnosis[7] + answer[1]; break;
            case "Спасибо": ret_question = "Жду Вас со снимком на повторный прием)"; break;
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
