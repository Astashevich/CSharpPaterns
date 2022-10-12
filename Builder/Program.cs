using Builder;

Console.WriteLine("Hello, World!");

IDeveloper iphoneDeveloper = new IPhoneDeveloper();

Director director = new(iphoneDeveloper);

Phone iphone = director.MountFullPhone();
Console.WriteLine(iphone.Data);

IDeveloper androidDeveloper = new AndroidDeveloper();

director.SetDeveloper(androidDeveloper);

Phone samsung = director.MountOnlyPhone();
Console.WriteLine(samsung.Data);
