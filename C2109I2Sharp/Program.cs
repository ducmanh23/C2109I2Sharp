using System.Text;
Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;

int number = 10;
string str = "manh";
double money = 9;
bool check = true;


//trong c sharp thường có 2 dạng kiểu chính
// 1 value type (dạng số) không chứa được null, 2 là reference type (chuỗi đối tượng) cho phép null;

string name = null;

//code cũ
Nullable<bool> a = null;

//code mới
int? b = null;
bool? flag = null;

// ?: => ternary operator
Console.WriteLine(name != null? true: false);
// is not null (!=)
// is (==)
Console.WriteLine(name is not null? true: false);

int age = 10;
if (age is 10)
{

}
// ? => null conditional operator
// ? dùng sau tên biến, hay đối tượng
// ? tương tự (!=), nếu cái gì đó khác null thì lấy cái vế sau

int? length = name?.Length;
if (name != null)
{
    length = name.Length;
}
else
{
    length = null;
}
// ?? => null coalescing operator
// ?? tương tự dấu ==, nếu cái gì đó bằng null thì lấy cái vế sau
 int? chieudai = name?.Length ?? 10;
