using System; // 告诉编译器这个程序使用System命名空间的类型。

namespace ConsoleApp3 // 声明一个新命名空间，名称为 ConsoleApp3 ，在这部分里声明的任何类型都是该命名空间的成员。
{
    internal class Program // 声明一个新的类类型，名称为 Program ，在这部分里声明的任何成员都是组成这个类的成员。
    {
        static void Main(string[] args) // 声明一个名称为 Main 的方法作为类 Program 的成员。在这个程序中，Main 是 Program 类的唯一成员。Main 是一个特殊函数，编译器用它作为程序的起始点。
        {
            Console.WriteLine("Hi there!"); // 只包含一条单独的、简单的语句，这一行组成了 Main 的方法体。简单语句以一个分号结束。这条语句使用命名空间 System 中的一个名称为 Console 的类将消息输出到屏幕窗口。没有第1行的 using 语句，编译器就不知道在哪里寻找类 Console。
        }
    }
}

// 笔记 2022年7月21日21:13:59 start

// 1、C#程序 由一个或多个类型声明组成。程序中的类型可以以任何顺序声明。命名空间 是与某个名称相关联的一组类型声明。

// 2、标识符 是一种字符串，用来命名变量、方法、参数和其他程序结构。标识符 区分大小写。
//    2.1、字母和下划线（a-z、A-Z 和 _）可以用在任何位置。
//    2.2、数字不能放在首位，但可以放在其他的任何地方。
//    2.3、@字符只能放在标识符的首位，虽然允许使用，但不推荐将@作为常用字符。

// 3、关键字 是用来定义C#语言的字符串记号。
//    3.1、关键字不能被用作变量名或任何其他形式的标识符，除非以@字符开始。
//    3.2、所有C#关键字全部都由小写字母组成（但是.NET类型名使用Pascal大小写约定）。

//    C#的关键字表
//    abstract  const  extern  int  out  short  typeof
//    as  continue  false  interface  override  sizeof  uint
//    base  decimal  finally  internal  params  stackalloc  ulong
//    bool  default  fixed  is  private  static  unchecked
//    break  delegate  float  lock  protected  string  unsafe
//    byte  do  for  long  public  struct  ushort
//    case  double  foreach  namespace  readonly  switch  using
//    catch  else  goto  new  ref  this  virtual
//    char  enum  if  null  return  throw  void
//    checked  event  implicit  object  sbyte  true  volatile
//    class  explicit  in  operator  sealed  try  when  while

//    上下文关键字 是仅在特定的语言结构中充当关键字的标识符。
//    C#的上下文关键字表
//    add  ascending  async  await  by  descending  dynamic
//    equals  from  get  global  group  in  into
//    join  let  on  orderby  partial  remove  select
//    set  value  var  where  yield

// 4、Main：程序的起始点。每个C#程序必须有一个类带有 Main 方法（函数）。
//    4.1、每个C#程序的可执行起始点在 Main 中的第一条指令。
//    4.2、Main 必须首字母大写。

// 5、空白，程序中的 空白 指的是没有可视化输出的字符。在源代码中使用的空白将被编译器忽略，但它会使代码 更清晰易读。
//    空白字符包括：空格（Space）、制表符（Tab）、换行符、回车符。

// 笔记 2022年7月21日21:47:56 end