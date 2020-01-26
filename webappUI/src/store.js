import Vue from 'vue'
import Vuex from 'vuex'

Vue.use(Vuex);

export const store = new Vuex.Store({
    state: {
        activateaddtask: false,
        authUser: {},
        isAuthenticated: false,
        jwt: localStorage.getItem('token'),
        endpoints: {
            // TODO: Remove hardcoding of dev endpoints
            baseURL: 'https://reqres.in/api/',
            obtainJWT: 'https://reqres.in/api/login/',

        },
        tasks: [
            {
                taskname: 'Molestias',
                taskcategory: 'Repairement',
                tasksubcategory: 'none',
                taskrecommondedprice: '81.56$/h',
                taskregion: 'Molestias',
                taskcreationdate: '2019-02-01',
                taskenddate: 'In progress',
                taskstatus: 'Task is defined',
                taskdescription: 'Aliquam tincidunt mauris eu risus...',
                taskaction: '',
                taskinfo: '',
                e1 : 1,
                taskid: 1,
                taskprogress: 0,
            },
        ],
    },

    mutations: {
        setAuthUser(state, {
            authUser,
            isAuthenticated
        }) {
            Vue.set(state, 'authUser', authUser)
            Vue.set(state, 'isAuthenticated', isAuthenticated)
        },
        updateToken(state, newToken) {
            // TODO: For security purposes, take localStorage out of the project.
            localStorage.setItem('token', newToken);
            state.jwt = newToken;
        },
        removeToken(state) {
            // TODO: For security purposes, take localStorage out of the project.
            localStorage.removeItem('token');
            state.jwt = null;
        },
        addTask(state, task) {
            state.tasks.push(task);
        },
        updatetaskstatus(state, {taskid, status}){
            console.log("in update status");
            console.log(taskid);
            state.tasks[taskid - 1].e1 = status;
            if(state.tasks[taskid - 1].e1 === 2){
                state.tasks[taskid - 1].taskstatus = "accepted an offer";
            }else if(state.tasks[taskid - 1].e1 === 3){
                state.tasks[taskid - 1].taskstatus = "Paid";
                state.tasks[taskid - 1].taskrecommondedprice = '1000$';
            }else if (state.tasks[taskid - 1].e1 === 4){
                state.tasks[taskid - 1].taskstatus = "task is done";
                state.tasks[taskid - 1].taskenddate =  state.tasks[taskid - 1].taskcreationdate;
            }
            console.log("in update status");
            console.log(state.tasks[taskid - 1].e1);
            console.log(status);
        },
        activeadd(state, active){
            state.activateaddtask = active;
            console.log("in store");
            console.log(state.activateaddtask);
        },

    }

});
