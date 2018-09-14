using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;

namespace WordCounter.Controllers
{
public class WordCounterController : Controller
{

  [HttpGet("/word")]
  public ActionResult Index()
  {
    return View();

  }
  [HttpGet("/word/new")]
  public ActionResult CreateForm()
  {
    return View();
  }

  [HttpPost("/word")]
  public ActionResult Create()
  {
  RepeatCounter newWord = new RepeatCounter(Request.Form["new-word"], Request.Form["new-result"]);

//split the words
  string[] splitArray = RepeatCounter.SplitTheText(newWord.GetUserInput());

//count the matching/loop
  int countIt = RepeatCounter.CountTheWords(newWord.GetUserResult(), splitArray);

    newWord.SetCountMatch(countIt);
    return View("Index", newWord);
  }
 }
}
