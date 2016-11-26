using UnityEngine;
using System.Collections;

public class Script : MonoBehaviour {

	static string[] eTypes = { "none", "simple", "index", "nested index", "filter" };
	

	// Use this for initialization
	void Start () {
		foreach (string eType in eTypes)
		{
			try
			{
				print("Start() try block reached.");
				print("ThrowException("+eType+") called.");
				ThrowException(eType);
				print("Start() try block continues.");
			}
			/*catch (System.IndexOutOfRangeException e) when (eType == "filter")
			{
				print("Main() FILTERED System.IndexOutOfRangeException catch block reached. Message:\n"+e.Message);
			}*/
			catch (System.IndexOutOfRangeException e)
			{
				if(eType=="filter")
					print("Start() FILTERED System.IndexOutOfRangeException catch block reached. Message:\n"+e.Message);
				else
					print("Start() System.IndexOutOfRangeException catch block reached. Message:\n"+e.Message);
			}
			catch
			{
				print("Start() general catch block reached.");
			}
			finally
			{
				print("Start() finally block reached.");
			}
		}
	}
	
	static void ThrowException(string exceptionType)
	{
		print("ThrowException("+exceptionType+") reached.");

		switch (exceptionType)
		{
		case "none":
			print("Not throwing an exception.");
			break;
		case "simple":
			print("Throwing System.Exception.");
			throw new System.Exception();
		case "index":
			print("Throwing System.IndexOutOfRangeException.");
			eTypes[5] = "error";
			break;
		case "nested index":
			try
			{
				print("ThrowException(\"nested index\") try block reached.");
				print("ThrowException(\"index\") called.");
				ThrowException("index");
			}
			catch
			{
				print ("ThrowException(\"nested index\") general catch block reached.");
				throw;
			}
			finally
			{
				print("ThrowException(\"nested index\") finally block reached.");
			}
			break;
		case "filter":
			try
			{
				print("ThrowException(\"filter\") try block reached.");
				print("ThrowException(\"index\") called.");
				ThrowException("index");
			}
			catch
			{
				print("ThrowException(\"filter\") general catch block reached.");
				throw;
			}
			break;
		}
	}
}
