# 29-08-Homework
Homework for 29-08-19
Task: 

Labs

Lab 1 : Out parameters

Declare a method which inputs three integers and returns the product ie the value of the three numbers multiplied together. Also return an out parameter which contains the sum of the three integers.

Lab 2 : Passing an object into a method

Create a Cat class which has a name and an age property. Create a constructor method also.

In the Methods class, create a static method called Age() which takes a Cat object as an input parameter. Inside the method, add 5 years to the age of the cat passed in.

Instantiate a Cat instance cat01 in the Main() method. In the constructor pass in the name as 'Tibby' with age 2.

Pass the Cat instance into the Age() method. Repeat this another time so the Age() method is called twice in all.

Use these two lines

using System.Web.Script.Serialization; 
note you must add a Reference first - you will have to Google for the reference name to add)and var json = new JavaScriptSerializer().Serialize(cat01);
to help you serialize the final cat object into JSON and return this JSON string.

{"name":"tilly","age":12}
