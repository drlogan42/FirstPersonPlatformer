using UnityEngine;
public class Notes
{

    /* 
    
         =-=-= Assigning =-=-=

    public allows inspector assigning and other scripts to use variable (CamelCase with uppercase on first)

    private means only that script can use the assigned variable (camelCase with lowercase on first)
    
    [SerializedField] on a private allows for inspector assignment while still having private attributes
    
    protected means only the class that is is assigned in can use the variable, meaning if a script inherits the Interactable class, they can get but not set

         =-=-= Using =-=-=

    when 'using' it imports namespaces, which are a collection of classes and data types (such as MonoBehavior, or objects in UnityEngine), can think of it like a
    -> library used for functionality like using using UnityEngine.SceneManagement allows for switching scenes

        =-=-= Classes =-=-=
    
    A class in laymans terms is a user defined data type that acts as a blueprint for creating object, which are instances of the class.

    A class defined the structure, behavior, and properties of objects

    An example is the Interactable class which inherits from MonoBehavior, inside can be functioncs such as virtual "Pickup()", and "Use()" which all instances of the class inherit.
 ?  -> I.e. Sword, Gun, Bow (Objects??) all inherit the functions from the class (Sword : Interactable)

    Can use public override void "FunctionNameHere()" to rewrite what the function does when called for each object within the class.

 ?  Within the base class, the virtual part of "public virtual void FunctionNameHere()" means it can be overridden within objects that inherit the class






    Other Topics


       =-=-= Enums =-=-=
       =-=-= Inheritance =-=-=
       =-=-= Abstraction =-=-=
       =-=-= Instances =-=-=
       =-=-= Attributes =-=-=
       =-=-= Methods =-=-=
    */

}
