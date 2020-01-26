import HelloWorld from "./components/HelloWorld";
import Taskee from "./components/taskee"
import Task from "./components/task"
import Home from "./components/home"
import Login from "./components/login"
import Eachtask from "./components/eachtask"
const routes = [
    {path: '/hello', component: HelloWorld},
    {path:'/', component: Taskee},
    {path:'/task', component: Task},
    {path:'/home', component: Home},
    {path:'/login', component: Login},
    {path:'/eachtask', component: Eachtask, props(route){return {taskid: route.query.taskid}}}
];
export default routes;