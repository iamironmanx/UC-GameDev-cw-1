using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class code1sh : MonoBehaviour
{

    string heroName = "Taleb";
    float heroHeight = 18.9f;
    int heroAge = 22;
    string heroSuperPower = "laser eyes";
    string villainName = "abdulrahman";
    float villainHeight = 10.5f;
    int villainAge = 20;
    string villainSuperPower = "power fist" ;

    // Start is called before the first frame update
    void Start()
    {
        int ageDifference = heroAge - villainAge;
        print("My name is " + heroName + " i am " + heroAge + " years old " + " my height is " + heroHeight + " my super power is " + heroSuperPower);
        print("My name is " + villainName + " i am " + villainAge + " years old " + " my height is " + villainHeight + " my super power is " + villainSuperPower);
        float ad5h = heroHeight + 5;
        print(ageDifference);
        print(ad5h);
        villainSuperPower = "none";
       
        print("My name is " + heroName + " i am " + heroAge + " years old " + " my height is " + heroHeight + " my super power is " + heroSuperPower);
        print("My name is " + villainName + " i am " + villainAge + " years old " + " my height is " + villainHeight + " my super power is " + villainSuperPower);
        print(ageDifference);
        print(ad5h);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
