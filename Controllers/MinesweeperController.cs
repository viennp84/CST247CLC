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
            gameBoard.buttons.ElementAt(bN).isVisited = 1;

            List<int> btns = gameBoard.GetChangedButton(gameBoard.buttons.ElementAt(bN).row, gameBoard.buttons.ElementAt(bN).column);
            foreach (var item in btns)
            {
                gameBoard.buttons.ElementAt(item).isVisited = 1;
            }

            var buttonHTMLString = RenderRazorViewToString(this, "ShowOneButton", gameBoard.buttons.ElementAt(bN));

            var messageHTMLString = "";
            if (gameBoard.buttons.ElementAt(bN).live == true)
            {
                messageHTMLString = "<p>GAME OVER</p>";
            }
            else
            {
                messageHTMLString = "<p>KEEP PLAYING</p>";
            }

            return Json(new { part1 = buttonHTMLString, part2 = messageHTMLString });
        }

        public IActionResult RightClickShowOneButton(int buttonNumber)
        {
            //gameBoard.buttons.ElementAt(buttonNumber). = 0;

            return PartialView("ShowOneButton", gameBoard.buttons.ElementAt(buttonNumber));
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