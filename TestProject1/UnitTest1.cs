using Newtonsoft.Json;
using Pomodoro_Timer;
using Pomodoro_Timer.Models;

namespace TestProject1
{
    public class Tests
    {

        public IEnumerable<int> GetTimeFromJson()
        {
            var model = GetTimeDataModel();
            foreach (var item in model.StudyTime)
            {
                yield return item;
            }
        }
        public TimeDataModel GetTimeDataModel()
        {
            string path = @"C:\Users\pkubo\Desktop\Pomodoro-Timer\Pomodoro Timer\DataFiles\lofi35_25_5_TimeData.json";
            string json = System.IO.File.ReadAllText(path);

            var timeDataModel = JsonConvert.DeserializeObject<TimeDataModel>(json);
            return timeDataModel;
        }


        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var model = GetTimeDataModel();
            Assert.That(model.StudyTime[0], Is.EqualTo(50));
            Assert.That(model.StudyTime[1], Is.EqualTo(10));
        }
        [Test]
        public void Test2()
        {
            var aa = GetTimeFromJson().GetEnumerator();
            for (int i = 0; i < 2; i++)
            {
                aa.MoveNext();
                var a = aa.Current;
                Assert.That(a, Is.EqualTo(50));
                aa.MoveNext();
                var a2 = aa.Current;
                Assert.That(a2, Is.EqualTo(10));
            }
        }
    }
}