using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ForkKnights.Group3 {
  public class Konovalov : IKnight {
    string name, power, fromUniverse, species, status;
    string mage{get; set;}
    int age;
    bool isHeAHero;

  public Konovalov() {
      mage = "Последний оплот";
      name = "Сифил Лифисов";
      power = "Изначально был рождён с очень сильной магией огня, из-за чего сошёл с ума";
      fromUniverse = "Выходец из вселенной, в которой правят драконы и царит средневековье";
      species = "Человек, рождённый в слиянии дракона и человека";
      status = "Является выходцем из богатой семьи";
      age = 15;
      isHeAHero = false;
    }

    public string GetJobApplication() {
      string background = $@"Он был рождён во времена драконов,{name}, {fromUniverse}, тут не ценят героев, драконы давно захватили эти земли" +
                          "и у людей не осталось надежды, из-за нехватки людей драконы стали размножаться с людьми, чтобы использовать их рабочую силу по максимуму" +
                          $@"и наш {name} {species}, он {power}, но это сыграет роль в будущем, из-за того, его мать страдает от отца Прафизизауруса он ненавидит драконов," +
                          $@"так как он {status} это позволяет ему изучать магию у самых лучших магов своего континента, являясь {age}-летним";
      return background;
    }
  }
}
