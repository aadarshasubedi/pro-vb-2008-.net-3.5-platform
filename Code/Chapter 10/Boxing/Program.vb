Option Explicit On
Option Strict On

' Structures are value types!
Structure MyPoint
  Public x, y As Integer
End StructureA 
Module Program

  Sub Main()
    Console.WriteLine("***** Fun with Boxing / Unboxing *****")
    Console.WriteLine()

    ' Make a short value type.
    Dim s As Short = 25

    ' Because s is passed into a 
    ' method prototyped to take an Object,
    ' it is 'boxed' automatically.
    UseThisObject(s)
 
    'Initializes a new instance of the ArrayList class that is empty and has the default initial capacity.
    'The capacity of an ArrayList is the number of elements that the ArrayList can hold. As elements are added to an ArrayList, the capacity is automatically increased as required by reallocating the internal array.
    'If the size of the collection can be estimated, specifying the initial capacity eliminates the need to perform a number of resizing operations while adding elements to the ArrayList.
    'This constructor is an O(1) operation.
    Dim myData As New ArrayList()
    myData.Add(88)
    myData.Add(3.33)
    myData.Add(False)

    ' Unbox first item from ArrayList.
    Dim firstItem As Integer = CType(myData(0), Integer)
    Console.WriteLine("First item is {0} ", firstItem)

    Dim p As MyPoint
    p.x = 10
    p.y = 20
    UseBoxedMyPoint(p)

    Console.ReadLine()
  End Sub

  Sub UseThisObject(ByVal o As Object)
    Console.WriteLine("Value of o is: {0} ", o)
  End Sub

  Sub UseBoxedMyPoint(ByVal o As Object)
    ' Error!  System.Object does not have
    ' member variables named 'x' or 'y'.
    If TypeOf o Is MyPoint Then
      Dim p As MyPoint = CType(o, MyPoint)
      Console.WriteLine("{0}, {1}", p.x, p.y)
    End If
  End Sub
End Module
