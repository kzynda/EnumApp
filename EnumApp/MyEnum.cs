namespace EnumApp;

public class MyEnum
{
	public int? Value;
	public Type? EnumType;

	public MyEnum()
	{
		Value = null;
		EnumType = null;
	}

	public void SetValue(object value)
	{
		var type = value.GetType();

		if (type != typeof(SomeEnum) && type != typeof(AnotherEnum))
		{
			throw new ArgumentOutOfRangeException();
		}

		Value = (int)System.Convert.ChangeType(value, type);
		EnumType = type;
	}
}