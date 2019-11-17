# CheckNullable
3. Реализовать для null-able типов, дополнительную возможность определения - является ссылка null или нет. Разработать модульные тесты.
   Примеры вызова: 
    - для переменной string name = "Kathy" =>  name.IsNull() --> false
    - для переменной string name = null    =>  name.IsNull() --> true
    - для переменной int? i = null         =>  i.IsNull()    --> true и т.д.
