using System.Diagnostics;
using System.Threading;
namespace killgwx{
	class Program{
		static void Main(string[] args){
			while(true){
				try {
					var kilp=Process.GetProcessesByName("GWX");
					foreach(var item in kilp){
						item.Kill();
					}
				}
				catch {}
				Thread.Sleep(100000);
			}
		}
	}
}