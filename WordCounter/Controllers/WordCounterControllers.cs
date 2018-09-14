using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WordDealership.Models;

namespace WordCounter.Controllers
{
public class WordController : Controller
{

  [HttpGet("/word")]
  public ActionResult Index()
  {
    List<Word> allWords = Word.GetAll();
    return View(allWords);

  }
  [HttpGet("/word/new")]
  public ActionResult CreateForm()
  {
    return View();
  }

  [HttpPost("/word")]
  public ActionResult Create()
  {
    Word newWord = new Word(Request.Form["new-word"]);
    List<Word> allWords = Word.GetAll();
    return View("Index", allWords);
  }

 //  [HttpPost("/word")]
 //  public ActionResult Act()
 //  {
 //    Text splitText = text.Split(' ');
 //    int matches = 0;
 //    foreach(string text in splitText)
 //  {
 //    if (text.Equals(input))
 //    {
 //       matches ++;
 //    }
 //    return View("Index", allWords)
 //  }
 // }
}
