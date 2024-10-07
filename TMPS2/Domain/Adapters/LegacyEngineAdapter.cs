namespace TMPS2;
// Adapter class that wraps the LegacyEngine and makes it compatible with Engine.

public class LegacyEngineAdapter : Engine
{
    private LegacyEngine _legacyEngine;

    public LegacyEngineAdapter(LegacyEngine legacyEngine)
    {
        _legacyEngine = legacyEngine;
    }

    public void Start() => _legacyEngine.StartEngine();
}