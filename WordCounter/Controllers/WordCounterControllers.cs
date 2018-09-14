using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WordDealership.Models;

namespace WordCounter.Controllers
{
public class WordController : Controller
{

  [HttpGet("/wordcounter")]
  public ActionResult Index()
  {
    List<Word> allWords = Word.GetAll();
    return View(allWords);

  }
  [HttpGet("/wordcounter/new")]
  public ActionResult CreateForm()
  {
    return View();
  }

  [HttpPost("/wordcounter")]
  public ActionResult Create()
  {
    Word newWord = new Word(Request.Form["new-word"]);
    List<Word> allWords = Word.GetAll();
    newWord.Save()
    return View("Index", allWords);
  }

  [HttpPost("/wordcounter/delete")]
  public ActionResult DeleteAll()
  {
    Word.ClearAll()
    return View();
  }

  [HttpPost("/wordcounter")]
  public ActionResult Act()
  {
  Word.CountTheWords(string input, string[] splitText)
  return View();

  }
}
