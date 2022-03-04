using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Task.Services.DTOs;
using Task.Services.Services.Interfaces;

namespace Task.Services.Services.Implementations
{
    public class InstructionsServices : IInstructionsServices
    {
        public InstructionsServices()
        {
        }

        public string TaskDetails()
        {

            return "Welcome to CogTest. Your task is to write some code (eg. console, html form, javascript, python etc.) to hit 2 API endpoints. You can use any language, framework, tool or library. The result of each endpoint will give you instructions on how to proceed. The first endpoint is /api/Step1 and requires a GET verb and a parameter value=40";
        }
        public List<InstructionsDTO> FirstSteps(int pageSize)
        {

            pageSize = pageSize > 0 ? pageSize : 10;

            #region List
            List<InstructionsDTO> resultList = new List<InstructionsDTO>();
            resultList.Add(new InstructionsDTO { describtion = "Lorem, ipsum dolor", details = " sit amet consectetur adipisicing elit. Nihil facilis", name = "assumenda", id = 1, order = 2 });
            resultList.Add(new InstructionsDTO { describtion = "impedit alias molestiae adipisci", details = " omnis quam beatae aspernatur quasi aliquam a rem", name = " hic", id = 1, order = 2 });
            resultList.Add(new InstructionsDTO { describtion = "magnam accusantium quidem animi", details = ". Tenetur est et dicta inventore. Cupiditate", name = "dolores", id = 1, order = 2 });
            resultList.Add(new InstructionsDTO { describtion = "perspiciatis ut ea non", details = " voluptates sit harum exercitationem labore laudantium porro nihil", name = "provident", id = 1, order = 2 });
            resultList.Add(new InstructionsDTO { describtion = "minima alias, eos", details = " sequi rem necessitatibus? Consequuntur nisi reiciendis aliquam", name = "fugit", id = 1, order = 2 });
            resultList.Add(new InstructionsDTO { describtion = "dignissimos, cumque libero", details = " quos quaerat? Consequuntur rerum officiis exercitationem consectetur", name = "aut", id = 1, order = 2 });
            resultList.Add(new InstructionsDTO { describtion = "nam molestiae aperiam accusamus", details = " provident excepturi ipsam cum, similique quae veritatis", name = "velit", id = 1, order = 2 });
            resultList.Add(new InstructionsDTO { describtion = "magnam quisquam consequatur", details = "officia magni voluptatum fugiat optio dolor minus accusantium id", name = " rerum", id = 1, order = 2 });
            resultList.Add(new InstructionsDTO { describtion = "dolores quidem nulla", details = "praesentium fuga alias unde expedita, facilis natus!", name = " Reiciendis", id = 1, order = 2 });
            resultList.Add(new InstructionsDTO { describtion = "ullam modi,", details = "repellendus officiis hic dolore doloremque dignissimos magnam excepturi est", name = " nulla", id = 1, order = 2 });
            resultList.Add(new InstructionsDTO { describtion = "perferendis ipsam nihil", details = " Veniam velit quidem, reiciendis aliquam earum ipsam nam", name = ",", id = 1, order = 2 });
            resultList.Add(new InstructionsDTO { describtion = "vitae reprehenderit nihil", details = "animi necessitatibus! Quia aut atque expedita fugit sit", name = " alias", id = 1, order = 2 });
            resultList.Add(new InstructionsDTO { describtion = "unde, doloribus", details = " ipsum placeat pariatur, accusantium excepturi odit corrupti deserunt", name = " ullam", id = 1, order = 2 });
            resultList.Add(new InstructionsDTO { describtion = "amet beatae expedita", details = "velit fuga sed saepe? Accusamus illo autem iure", name = " at", id = 1, order = 2 });
            resultList.Add(new InstructionsDTO { describtion = "aliquid dolore provident", details = "sequi eius sunt ullam suscipit, vel esse vero", name = " neque", id = 1, order = 2 });
            resultList.Add(new InstructionsDTO { describtion = "expedita repellat maiores", details = "error placeat numquam praesentium eaque labore suscipit, voluptatum", name = " accusantium", id = 1, order = 2 });
            resultList.Add(new InstructionsDTO { describtion = "nihil veniam et", details = "temporibus inventore necessitatibus asperiores. Porro hic aperiam a", name = ",", id = 1, order = 2 });
            resultList.Add(new InstructionsDTO { describtion = "eos tempore in", details = "illo quam, ea vitae animi sunt unde!", name = " Temporibus", id = 1, order = 2 });
            resultList.Add(new InstructionsDTO { describtion = "Qui, a", details = "vero ut reprehenderit illum tempore alias nesciunt et?", name = " Vitae", id = 1, order = 2 });
            resultList.Add(new InstructionsDTO { describtion = "accusantium sunt magni", details = "culpa. Odit quos corrupti atque enim, unde", name = " ipsum", id = 1, order = 2 });
            resultList.Add(new InstructionsDTO { describtion = "et inventore ad", details = "officiis dignissimos nemo accusamus adipisci quisquam officia voluptas molestias", name = " consequatur", id = 1, order = 2 });
            resultList.Add(new InstructionsDTO { describtion = "perferendis aliquid cum", details = "sequi asperiores obcaecati ipsam, debitis ratione. Exercitationem", name = " asperiores", id = 1, order = 2 });
            resultList.Add(new InstructionsDTO { describtion = "tenetur voluptatibus eos", details = "odio unde debitis? Amet sint dolorem aut nam", name = " esse", id = 1, order = 2 });
            resultList.Add(new InstructionsDTO { describtion = "Dolorem natus,", details = "dignissimos voluptatem aliquam facere dolore ducimus unde reprehenderit beatae", name = " tempora", id = 1, order = 2 });
            resultList.Add(new InstructionsDTO { describtion = "nesciunt animi excepturi", details = "quas nisi quam in asperiores! Unde, iste", name = " illo", id = 1, order = 2 });
            resultList.Add(new InstructionsDTO { describtion = "numquam iste atque", details = "quo ab, voluptates at necessitatibus! Odit soluta", name = " dolorum", id = 1, order = 2 });
            resultList.Add(new InstructionsDTO { describtion = "Repellendus ex facere", details = "doloribus. Earum nulla possimus laborum voluptate tenetur non", name = " atque", id = 1, order = 2 });
            resultList.Add(new InstructionsDTO { describtion = "voluptatibus eveniet cum", details = "maxime sequi, veniam velit odio corrupti alias eligendi", name = " hic", id = 1, order = 2 });
            resultList.Add(new InstructionsDTO { describtion = "Excepturi rerum,", details = "esse nesciunt quo culpa rem ea facere, magni", name = " quaerat", id = 1, order = 2 });
            resultList.Add(new InstructionsDTO { describtion = "aliquam sapiente amet", details = " ad cupiditate minus doloremque omnis autem perferendis! Sunt", name = " consequuntur", id = 1, order = 2 });
            resultList.Add(new InstructionsDTO { describtion = "mollitia illum nemo", details = "possimus iusto beatae aliquam, recusandae, cupiditate modi", name = " ipsam", id = 1, order = 2 });
            resultList.Add(new InstructionsDTO { describtion = "facilis quod molestias", details = "quos non. Mollitia molestiae accusamus alias et nesciunt", name = ",", id = 1, order = 2 });
            resultList.Add(new InstructionsDTO { describtion = "inventore? Assumenda", details = " est! Sed quibusdam odit enim tenetur molestiae necessitatibus", name = " soluta", id = 1, order = 2 });
            resultList.Add(new InstructionsDTO { describtion = "Quasi qui,", details = "sed harum consectetur eligendi laboriosam corrupti in. Repudiandae", name = " reprehenderit", id = 1, order = 2 });
            resultList.Add(new InstructionsDTO { describtion = "magni eveniet est", details = "similique tempore libero ut obcaecati esse natus ipsam perferendis", name = " quos", id = 1, order = 2 });
            resultList.Add(new InstructionsDTO { describtion = "incidunt. Facilis", details = "dolorum optio rem quibusdam culpa tempora, aperiam mollitia", name = " ut", id = 1, order = 2 });
            resultList.Add(new InstructionsDTO { describtion = "beatae ipsam distinctio", details = "eaque consectetur voluptatem numquam vel officiis quas architecto ad", name = " quisquam", id = 1, order = 2 });
            resultList.Add(new InstructionsDTO { describtion = "consequuntur ut!", details = "Cupiditate similique debitis soluta exercitationem laboriosam sed quod at", name = " illo", id = 1, order = 2 });
            resultList.Add(new InstructionsDTO { describtion = "alias aliquam quae", details = "maiores ipsum totam iste sunt quis, voluptate reprehenderit", name = " vero", id = 1, order = 2 });
            resultList.Add(new InstructionsDTO { describtion = "delectus laboriosam molestiae", details = "quod excepturi expedita quam magni, perferendis distinctio pariatur", name = "?", id = 1, order = 2 });
            resultList.Add(new InstructionsDTO { describtion = "nam fuga ab", details = "id sit distinctio, saepe totam placeat voluptatem eveniet", name = " exercitationem", id = 1, order = 2 });
            resultList.Add(new InstructionsDTO { describtion = "expedita recusandae ad", details = "mollitia dignissimos alias! Neque unde quas voluptatum,", name = " eligendi", id = 1, order = 2 });
            resultList.Add(new InstructionsDTO { describtion = "placeat earum et", details = "labore. Facilis veniam impedit, optio aspernatur tenetur", name = " voluptas", id = 1, order = 2 });
            resultList.Add(new InstructionsDTO { describtion = "commodi expedita,", details = "iure perspiciatis similique eum perferendis magnam, voluptatibus esse", name = ".", id = 1, order = 2 });
            resultList.Add(new InstructionsDTO { describtion = "facilis beatae nihil", details = "minima quos voluptates doloribus dolores optio eius, perferendis", name = ",", id = 1, order = 2 });
            resultList.Add(new InstructionsDTO { describtion = "reprehenderit exercitationem suscipit", details = "similique ea eos iste placeat. Repudiandae fuga veritatis", name = ",", id = 1, order = 2 });
            resultList.Add(new InstructionsDTO { describtion = "laudantium, voluptas", details = "voluptatum quia dolor quo impedit saepe. Facilis illo", name = " tempore", id = 1, order = 2 });
            resultList.Add(new InstructionsDTO { describtion = "dicta enim suscipit", details = "delectus nemo? Voluptatum repudiandae ipsam ut, quibusdam", name = " necessitatibus", id = 1, order = 2 });
            resultList.Add(new InstructionsDTO { describtion = "aliquid nam inventore", details = "veritatis nemo consequuntur? Sed totam laudantium hic sequi", name = " minima", id = 1, order = 2 });
            resultList.Add(new InstructionsDTO { describtion = "aspernatur iste.", details = "Dolor rerum deserunt iusto velit fugit perspiciatis omnis illum", name = ",", id = 1, order = 2 });
            resultList.Add(new InstructionsDTO { describtion = "aliquam optio sint", details = "qui perspiciatis. Amet, natus. Earum enim", name = ",", id = 1, order = 2 });
            resultList.Add(new InstructionsDTO { describtion = "dolore magni dicta", details = "tempore ea ratione aspernatur voluptas amet sunt maxime unde", name = " praesentium", id = 1, order = 2 });
            resultList.Add(new InstructionsDTO { describtion = "incidunt error tempore", details = "nulla quaerat quam quo obcaecati. Fugit iste tempora", name = " possimus", id = 1, order = 2 });
            resultList.Add(new InstructionsDTO { describtion = "repellat quaerat alias", details = "corrupti, ut, labore provident sit assumenda tenetur", name = " recusandae", id = 1, order = 2 });
            resultList.Add(new InstructionsDTO { describtion = "magni rem quisquam", details = "sint sequi. Adipisci assumenda quia doloremque esse soluta", name = "?", id = 1, order = 2 });
            resultList.Add(new InstructionsDTO { describtion = "molestias modi qui", details = "tenetur cum dignissimos illo accusantium. Mollitia officiis,", name = " molestiae", id = 1, order = 2 });
            resultList.Add(new InstructionsDTO { describtion = "ab fugiat quidem", details = "nesciunt dignissimos eos sapiente perspiciatis! Aut incidunt iste", name = " sed", id = 1, order = 2 });
            resultList.Add(new InstructionsDTO { describtion = "ullam eligendi illo", details = "laudantium recusandae excepturi accusantium perspiciatis exercitationem et officia quod", name = " dolores", id = 1, order = 2 });
            resultList.Add(new InstructionsDTO { describtion = "Minima porro animi", details = "dolorum repellendus deleniti quod tempore minus nobis sed quis", name = " ullam", id = 1, order = 2 });
            resultList.Add(new InstructionsDTO { describtion = "voluptatibus incidunt?", details = "Autem esse aut necessitatibus unde rerum quasi omnis perferendis", name = " laudantium", id = 1, order = 2 });
            resultList.Add(new InstructionsDTO { describtion = "fugit modi voluptate", details = "exercitationem natus illum ex, assumenda, cum eos", name = ".", id = 1, order = 2 });
            resultList.Add(new InstructionsDTO { describtion = "esse totam eum", details = "voluptatem, eos rem, explicabo praesentium, non", name = " adipisci", id = 1, order = 2 });
            resultList.Add(new InstructionsDTO { describtion = "Fugiat nihil aut", details = "odio eius id. Obcaecati odit consectetur rerum tempora", name = " repellat", id = 1, order = 2 });
            resultList.Add(new InstructionsDTO { describtion = "Soluta magni totam", details = "quod magnam ducimus laboriosam aspernatur enim, voluptas unde", name = " numquam", id = 1, order = 2 });
            resultList.Add(new InstructionsDTO { describtion = "doloribus labore velit", details = "quia beatae ea dignissimos aliquid facilis consequuntur rerum eaque", name = " amet", id = 1, order = 2 });
            resultList.Add(new InstructionsDTO { describtion = "qui temporibus non", details = "dolore corrupti sed odio modi eum! Itaque hic", name = ",", id = 1, order = 2 });
            resultList.Add(new InstructionsDTO { describtion = "laboriosam fugiat reiciendis", details = " Dolorum, sed nesciunt. Est eum facere placeat", name = " architecto", id = 1, order = 2 });
            resultList.Add(new InstructionsDTO { describtion = "exercitationem, adipisci", details = " laudantium possimus eaque debitis necessitatibus aspernatur, deserunt rem", name = " nemo", id = 1, order = 2 });
            resultList.Add(new InstructionsDTO { describtion = "voluptatem quidem praesentium", details = "quisquam id repudiandae laborum molestias. Amet odit vero", name = " fugit", id = 1, order = 2 });
            resultList.Add(new InstructionsDTO { describtion = "cumque distinctio!", details = "Totam sint nulla porro repudiandae iusto reprehenderit eligendi animi", name = " voluptatem", id = 1, order = 2 });
            resultList.Add(new InstructionsDTO { describtion = "accusamus nesciunt deleniti", details = "libero quo quae maiores voluptates soluta doloribus minus qui", name = " incidunt", id = 1, order = 2 });
            resultList.Add(new InstructionsDTO { describtion = "ut, adipisci", details = "amet aliquid quod temporibus laudantium officiis quibusdam dignissimos expedita", name = " dolores", id = 1, order = 2 });
            resultList.Add(new InstructionsDTO { describtion = "reprehenderit sit possimus", details = "porro sequi non harum, assumenda minus minima vero", name = " perferendis", id = 1, order = 2 });
            resultList.Add(new InstructionsDTO { describtion = "Necessitatibus corrupti,", details = "doloremque vel labore nostrum, ab quibusdam molestiae,", name = " deserunt", id = 1, order = 2 });
            resultList.Add(new InstructionsDTO { describtion = "eligendi praesentium quis", details = "eaque earum illum? Provident, doloribus libero!", name = " Quisquam", id = 1, order = 2 });
            resultList.Add(new InstructionsDTO { describtion = "placeat nam animi", details = "quia laborum non voluptas similique eveniet nostrum id aut", name = " temporibus", id = 1, order = 2 });
            resultList.Add(new InstructionsDTO { describtion = "consequuntur neque iusto", details = "laboriosam. Architecto ducimus odio sint. Odio veritatis", name = " incidunt", id = 1, order = 2 });
            resultList.Add(new InstructionsDTO { describtion = "consectetur ipsa cum", details = "unde maxime laborum voluptate ipsum, quaerat ea porro", name = " dolore", id = 1, order = 2 });
            resultList.Add(new InstructionsDTO { describtion = "neque corporis quos", details = "quidem nam. Corrupti repudiandae modi quos suscipit sequi", name = " ex", id = 1, order = 2 });
            resultList.Add(new InstructionsDTO { describtion = "Voluptatum beatae nobis", details = "modi distinctio magni, natus possimus quibusdam necessitatibus sunt", name = " libero", id = 1, order = 2 });
            #endregion

            return resultList.Take(pageSize).ToList();
        }

    }
}
