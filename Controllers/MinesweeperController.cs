using CST247CLC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CST247CLC.Controllers
{
    public class MinesweeperController : Controller
    {
        static GameBoard gameBoard = new GameBoard(10);

        public IActionResult Index()
        {

            //Send the button list to the "Index" page
            return View("Index", gameBoard.buttons);
        }

        public IActionResult HandleButtonClick(string buttonNumber)
        {
            int bN = int.Parse(buttonNumber);
            gameBoard.buttons.ElementAt(bN).isVisited = 1;

            List<int> btns = gameBoard.GetChangedButton(gameBoard.buttons.ElementAt(bN).row, gameBoard.buttons.ElementAt(bN).column);
            foreach (var item in btns)
            {
                gameBoard.buttons.ElementAt(item).isVisited = 1;
            }

            return View("Index", gameBoard.buttons);
        }

        public IActionResult ShowOneButton(int buttonNumber)
        {
            int bN = buttonNumber;

            //if flag is true, dont do anything
            if (gameBoard.buttons.ElementAt(bN).flag)
            {
                var part1 = RenderRazorViewToString(this, "ShowOneButton", gameBoard.buttons);
                return Json(new { part1 = part1, part2 = "<p>KEEP PLAYING</p>" });
            }

            gameBoard.buttons.ElementAt(bN).isVisited = 1;

            List<int> btns = gameBoard.GetChangedButton(gameBoard.buttons.ElementAt(bN).row, gameBoard.buttons.ElementAt(bN).column);
            foreach (var item in btns)
            {
                gameBoard.buttons.ElementAt(item).isVisited = 1;
            }

            var messageHTMLString = "";
            if (gameBoard.buttons.ElementAt(bN).live == true)
            {
                for (int i = 0; i < gameBoard.buttons.Count; i++)
                {
                    gameBoard.buttons.ElementAt(i).isVisited = 1;
                }
                messageHTMLString = "<p>GAME OVER</p>";
            }
            else
            {
                messageHTMLString = "<p>KEEP PLAYING</p>";

                int count = 0;
                for (int i = 0; i < gameBoard.buttons.Count; i++)
                {
                    if(gameBoard.buttons.ElementAt(i).isVisited == 1)
                    {
                        count++;
                    }
                }
                if((gameBoard.buttons.Count - count) == gameBoard.numOfBombs)
                {
                    messageHTMLString = "<p>YOU WON! CONGRATULATIONS</p>";
                }
            }

            var buttonHTMLString = RenderRazorViewToString(this, "ShowOneButton", gameBoard.buttons);

            return Json(new { part1 = buttonHTMLString, part2 = messageHTMLString });
        }

        public IActionResult RightClickShowOneButton(int buttonNumber)
        {
            if(gameBoard.buttons.ElementAt(buttonNumber).flag)
            {
                gameBoard.buttons.ElementAt(buttonNumber).flag = false;
            }
            else
            {
                gameBoard.buttons.ElementAt(buttonNumber).flag = true;
            }

            var buttonHTMLString = RenderRazorViewToString(this, "ShowOneButton", gameBoard.buttons);

            return Json(new { part1 = buttonHTMLString, part2 = "KEEP PLAYING" });
        }

        public static string RenderRazorViewToString(Controller controller, string viewName, object model = null)
        {
            controller.ViewData.Model = model;
            using (var sw = new StringWriter())
            {
                IViewEngine viewEngine =
                    controller.HttpContext.RequestServices.GetService(typeof(ICompositeViewEngine)) as
                        ICompositeViewEngine;
                ViewEngineResult viewResult = viewEngine.FindView(controller.ControllerContext, viewName, false);

                ViewContext viewContext = new ViewContext(
                    controller.ControllerContext,
                    viewResult.View,
                    controller.ViewData,
                    controller.TempData,
                    sw,
                    new HtmlHelperOptions()
                );
                viewResult.View.RenderAsync(viewContext);
                return sw.GetStringBuilder().ToString();
            }
        }
    }
}