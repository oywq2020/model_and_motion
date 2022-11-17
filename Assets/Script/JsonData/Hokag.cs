using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hokag 
{
   public string Name { get; set; }
   public int Age { get; set; }
   public string Skill { get; set; }
   
   public override string ToString()
   {
      return $"姓名：{Name}，年龄：{Age}，技能：{Skill}";
   }
}
