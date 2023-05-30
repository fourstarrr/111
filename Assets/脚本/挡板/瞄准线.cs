using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class 瞄准线 : MonoBehaviour
{
    private Scene _simulationScene;
    private PhysicsScene _physicsScene;
    [SerializeField] private Transform _obstaclesparent;

    private void Start()
    {
        CreatePhysicScene();
    }
    void CreatePhysicScene()
    {
        _simulationScene = SceneManager.CreateScene("Simulation", new CreateSceneParameters(LocalPhysicsMode.Physics3D));
        _physicsScene = _simulationScene.GetPhysicsScene();
        foreach (Transform obj in _obstaclesparent)
        {
            var ghostObj = Instantiate(obj.gameObject, obj.position, obj.rotation);
            ghostObj.GetComponent<Renderer>().enabled = false;
            SceneManager.MoveGameObjectToScene(ghostObj,_simulationScene);
        }
    }

    // Update is called once per frame
   /* void Update()
    {
        
    }
    public void SimulateTrajectory(球 ball,Vector3 pos, Vector3 velocity)
    {
        var ghostObj = Instantiate(ball, pos,Quaternion.identity) ;
        ghostObj.GetComponent<Renderer>().enabled = false;
        SceneManager.MoveGameObjectToScene(ghostObj.gameObject, _simulationScene);
        ghostObj.
    }*/
}
