namespace OOP.Task_02;
public sealed class MissionOperations
{
    static Mission[] missions = new Mission[0];
    public void Create(Mission mission)
    {
        Resize(missions.Length + 1);
        missions[missions.Length - 1] = mission;
    }
    public Mission RetrieveById(int id)
    {
        if (!Any(id))
            return null;

        for (int i = 0 ; i < missions.Length ; i++)
            if (missions[i].Id == id)
                return missions[i];

        return null;
    }
    public void Update(Mission mission, int id)
    {
        if (!Any(id))
            return;

        for (int i = 0 ; i < missions.Length ; i++)
            if (missions[i].Id == id)
                missions[i] = mission;
    }
    public void Delete(int id)
    {
        if (!Any(id))
            return;

        for (int i = 0 ; i < missions.Length ; i++)
            if (missions[i].Id == id)
                missions[i] = null;

        Resize(missions.Length - 1);
    }
    public bool Any(int id)
    {
        bool isFounded = false;

        for (int i = 0 ; i < missions.Length ; i++)
            if (missions[i].Id == id)
                isFounded = true;

        return isFounded;
    }
    private void Resize(int newSize)
    {
        Mission[] newMissionss;
        newMissionss = new Mission[newSize];
        if (newSize > missions.Length)
        {
            for (int i = 0 ; i < missions.Length ; i++)
                newMissionss[i] = missions[i];
            missions = newMissionss;
        }
        else
        {
            for (int i = 0, j = 0 ; i < missions.Length ; i++)
            {
                if (missions[i] != null)
                {
                    newMissionss[j] = missions[i];
                    j++;
                }
            }
            missions = newMissionss;
        }
    }

    public int Count()
    {
        return missions.Count();
    }
}
