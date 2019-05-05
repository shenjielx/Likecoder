# Likecoder

Likecoder

## 2019-05-05 version-0.1

### 1、IsTrue() or IsFalse()

string, short, int, long, double, decimal, bool, List, IList, IEnumerable, IQueryable

"123".IsTrue() // true
" ".IsFalse() // true

### 2、Left() or Right()

"1234567".Left(3) // "123"
"xyz91is".Right(4) // "91is"

### 3、WhereIf()

var keyword="1";
var list=new List<string>{"1","2","1"};
list.WhereIf(x=>x==keyword, keyword);
// or
list.WhereIf(x=>x==keyword, keyword.IsTrue());

### 4、WhereTrue() or WhereFalse()

var keyword="1";
var list=new List<string>{"1","2","1", "", " "};
list.WhereTrue(); // {"1","2","1"}
list.WhereFalse(); // {"", " "}
