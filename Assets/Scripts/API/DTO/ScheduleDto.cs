using UnityEngine;

//Data transfer object to represent inbound and outbound schedule state. Please have this match 1:1 to server-side DTO.
[SerializeField]
public class ScheduleDto : JsonEncodableData {
    [SerializeField]
    string taName = null;
    [SerializeField]
    string scheduleType = null;
    [SerializeField]
    string date = null;
    [SerializeField]
    string[] schedulesByDay = null;

    public ScheduleDto(string taName, string scheduleType, string date, string[] schedule) {
        this.taName = taName;
        this.scheduleType = scheduleType;
        this.date = date;
        this.schedulesByDay = schedule;
    }

    public void SetSchedulesByDay(string[] schedule) {
        this.schedulesByDay = schedule;
    }

    public string[] GetSchedulesByDay() {
        return schedulesByDay;
    }

    public void SetTaName(string name) {
        this.taName = name;
    }

    public string GetTaName() {
        return taName;
    }

    public void SetDate(string date)
    {
        this.date = date;
    }

    public string GetDate()
    {
        return date;
    }

    public void SetScheduleType(string scheduleType)
    {
        this.scheduleType = scheduleType;
    }

    public string GetScheduleType()
    {
        return scheduleType;
    }
}
