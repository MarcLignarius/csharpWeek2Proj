using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using WordCounter.Models;

namespace WordCounter.Controllers
{
  public class WordCounterController : Controller
  {

    [HttpGet("/wordcounter")]
    public ActionResult Index(RepeatCounter myRepeatCounter)
    {
        return View(myRepeatCounter);
    }

    [HttpPost("/wordcounter")]
    public ActionResult Create(string userInputsentence, string userInputWord)
    {
        RepeatCounter myRepeatCounter = new RepeatCounter(userInputsentence, userInputWord);
        return View("Index", myRepeatCounter);
    }

    [Route("/wordcounter/new")]
    public ActionResult CreateForm()
    {
        return View();
    }

  }

}
