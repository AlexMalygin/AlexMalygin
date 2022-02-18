// Проверить истинность утверждения 
//¬(X ⋁ Y) = ¬X ⋀ ¬Y

void Check(bool x, bool y)
 {
     Console.WriteLine($"!({x} || {y}) = {!(x || y)}, !{x} && !{y} = {!x && !y}");
 }

 Check(false, false);
 Check(false, true);
 Check(true, false);
 Check(true, true); 
