
using Task2;

var post1 = new Post();
post1.Title = "Weekend";
post1.Description = "Good Day";
post1.Publish();
post1.Comment("Wooow");
post1.Like();
post1.Like();


var post2 = new Post();
post2.Title = "Ierlandiya";
post2.Description = "Cold";
post2.Publish();
post2.Comment("Amazing");
post2.Comment("Coool");
post2.Like();
post2.Like();
post2.Like();



var post3 = new Post();
post3.Title = "My Home";
post3.Description = "With Familly";
post3.Publish();
post3.Like();
post3.Like();
post3.Like();
post3.Like();




var post4 = new Post();
post4.Title = "SoftClub";
post4.Description = "My First Class Work";
post4.Publish();
post4.Comment("OMG!");
post4.Comment("Amazing!");
post4.Comment("Prety good!");
post4.Comment("Good Job Boy!");
post4.Like();
post4.Like();
post4.Like();




var post5 = new Post();
post5.Title = "Just Beuty day";
post5.Description = "Varzob";
post5.Publish();
post5.Comment("Voooo");
post5.Like();

List<Post> posts = new List<Post>();

posts.Add(post1);
posts.Add(post2);
posts.Add(post3);
posts.Add(post4);
posts.Add(post5);
foreach (var it in posts)
{
    System.Console.WriteLine($"{it.Title} - {it.Description} - number Likes: {it.LikeCount}");
    System.Console.WriteLine("------------------------------------------------------------");

foreach (var item in it.Comments )
{
    System.Console.WriteLine($"Comments: {item}");
}
}