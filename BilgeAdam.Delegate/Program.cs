namespace BilgeAdam.Delegate
{
    public delegate int MathOperationHandler(int x, int y);

    public delegate void ConsoleOperationHandler<T>(T args);

    internal class Program
    {
        public static void Main(string[] arg)
        {
            //var instance = new SimpleMath();
            //var mathOp = new MathOperationHandler(SimpleMath.Sum);
            //mathOp += SimpleMath.Subtract;
            //mathOp -= SimpleMath.Subtract;
            //mathOp -= SimpleMath.Sum;
            //var result = mathOp(5, 3);
            //Calculate(mathOp);

            //var stringOperation = new ConsoleOperationHandler<string>(StringDisplayer);
            //var intOperation = new ConsoleOperationHandler<int>(IntDisplayer);
            //stringOperation("Sergen");
            //intOperation(5);
            //Func<input,input,...,output> dönüş tipi olan delegate
            //Action<input,input,...,input> void methodları temsil eder.
            var entity = new Product { Id = 1, Name = "Deneme ürünü", CreatedAt = DateTime.Now, isActive = true, isDeleted = false };
            var result = Mapper<Product, ProductViewDto>(entity, ProductMapper);
            var result2 = Mapper<Product, ProductViewDto>(entity, entity=> new ProductViewDto { Id = entity.Id, Name = entity.Name});
            //var result3 = Mapper<Category, CategoryDto>(entity, entity=> new CategoryDto { Id = entity.Id, Name = entity.CategoryName});
            //var result2 = Mapper<Product, ProductViewDto>(entity, (entity, asdasd) => { Console.WriteLine(entity.Id); });

        }

        public static ProductViewDto ProductMapper(Product entity)
        {
            Console.WriteLine(entity.Id);
            return new ProductViewDto { Id = entity.Id, Name = entity.Name };
        }

        public static TDto Mapper<TEntity, TDto>(TEntity entity, Func<TEntity, TDto> mapFunction)
        {
           return mapFunction(entity);
        }

        private static void StringDisplayer(string args)
        {
            Console.WriteLine(args);
        }

        private static void IntDisplayer(int args)
        {
            Console.WriteLine(args++);
        }

        public static void Calculate(MathOperationHandler mathOp)
        {
            var result = mathOp(2, 6);
        }
    }

    class Product //entity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool isDeleted { get; set; }
        public bool isActive { get; set; }
    }
    class Category //entity
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool isDeleted { get; set; }
        public bool isActive { get; set; }
    }
    class CategoryDto //entity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool isDeleted { get; set; }
        public bool isActive { get; set; }
    }

    class ProductViewDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class SimpleMath
    {
        public int Age { get; set; }

        public static int Sum(int x, int y)
        {
            var result = x + y;
            Console.WriteLine(result);
            return result;
        }

        public static int Subtract(int x, int y)
        {
            var result = x - y;
            Console.WriteLine(result);
            return result;
        }
    }
}