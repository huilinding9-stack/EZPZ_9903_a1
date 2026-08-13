using UnityEngine;
using UnityEngine.AI;

public class Tips : MonoBehaviour
{
    public GameObject nextTip;
    public LineRenderer lineRender;
    public Transform player;
    //public string tipContent;
    public NavMeshPath navMeshPath;
   

    //private void UpdateLine()
    //{
    //    NavMeshAgent navMeshAgent = player.GetComponent<NavMeshAgent>();
    //    navMeshPath = new NavMeshPath();
    //    bool res = NavMesh.CalculatePath(player.transform.position, transform.position, navMeshAgent.areaMask, navMeshPath);
    //    if (res)
    //    {
    //        Vector3[] paths = navMeshPath.corners;
    //        if (paths != null && paths.Length >= 2)
    //        {
    //            for (int i = 0; i < paths.Length; i++)
    //            {
    //                paths[i] += Vector3.up * 0.1f;
    //            }
    //            lineRender.gameObject.SetActive(true);
    //            lineRender.positionCount = paths.Length;
    //            lineRender.SetPositions(paths);
    //        }
    //        else { 
    //            lineRender.gameObject.SetActive(false);
    //        }
    //    }
    //}
    //private void Update()
    //{
    //    UpdateLine();
    //}

    //private void OnDestroy()
    //{
    //    lineRender.gameObject.SetActive(false);
    //}
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            //if (tipContent != "")
            //{
            //    Toast.Instance.ShowContent(tipContent);
            //}
            GameObject.Destroy(gameObject);
               //if (nextTip != null)
             //  {
            //       nextTip.SetActive(true);
            //   }
        }
    }
}
