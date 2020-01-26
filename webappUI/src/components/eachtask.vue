 <template>
        <v-app class="grey lighten-5">
            <v-content>
                <toolbar></toolbar>
                <v-layout row>
                    <v-flex lg2>
                        <navbar></navbar>
                    </v-flex>
                    <v-flex lg10>
                        <v-container width="120vw" fluid v-if="e1 < 4">
                            <v-container class="ml-0 mt-2 mb-6 mr-0">
                                <span class="text-lg-left font-weight-bold font-weight-black" style="font-size: xx-large">Task</span>
                            </v-container>
                            <v-container fluid>
                                <v-card width="79vw" height="20vh">
                                    <v-card-text class="font-weight-bold font-weight-black">Task Status Bar</v-card-text>

                                    <v-card flat style="margin-left: 80px; margin-right: 80px;">

                                        <v-stepper alt-labels v-model="e1" style="box-shadow: none;" class="mr-12 ml-12">
                                            <v-stepper-header>
                                                <v-stepper-step step="1" color="#7cfc00" :complete="e1 > 0" >Definition</v-stepper-step>
                                                <v-divider></v-divider>
                                                <v-stepper-step step="2" color="#7cfc00" :complete="e1 > 1">Offers</v-stepper-step>
                                                <v-divider></v-divider>
                                                <v-stepper-step step="3" color="#7cfc00" :complete="e1 > 2">Payement</v-stepper-step>
                                                <v-divider></v-divider>
                                                <v-stepper-step step="4" color="#7cfc00" :complete="e1 > 3">status</v-stepper-step>
                                            </v-stepper-header>
                                        </v-stepper>
                                    </v-card>
                                </v-card>
                            </v-container>
                            <v-container class="mx-0 px-0" fluid>
                                <v-row>
                                <v-dialog v-model="dialog" width="500px">
                                    <v-card height="50vh" width="500px">
                                        <v-card-title>Offers</v-card-title>
                                        <v-spacer></v-spacer>
                                        <v-divider></v-divider>
                                        <v-card-text>
                                            <v-row>
                                                <v-col cols="12" lg="12" class="font-weight-bold">
                                            <v-avatar size="100px">
                                                <v-img :src="taskeravatar"></v-img>
                                            </v-avatar>
                                                    <span class="ml-6">{{ taskername}}</span>

                                                    <span class="green--text ml-12 pl-12">{{taskerprice}}</span>
                                                </v-col>

                                            </v-row>
                                            <v-row>
                                           <v-card>
                                               <v-card-text>
                                                   The accomplishment of a given task measured against preset known standards of accuracy, completeness, cost, and speed. In a contract, performance is deemed to be the fulfillment of an obligation, in a manner that releases the performer from all liabilities under the contract.
                                               </v-card-text>
                                           </v-card>
                                            </v-row>
                                        </v-card-text>
                                        <v-divider></v-divider>
                                        <v-card-actions>
                                            <v-spacer></v-spacer>
                                            <v-btn color="success" class="white--text" @click="addfunc">Accept</v-btn>
                                            <v-btn outlined color="success" class="ml-10" @click="dialog = !dialog">Reject</v-btn>
                                            <v-spacer></v-spacer>
                                        </v-card-actions>

                                    </v-card>
                                </v-dialog>
                                </v-row>
                            <v-row class="mr-4 ml-1">
                                <v-col cols="12" lg="4">
                                    <v-card height="70vh" width="30vw"  v-if="e1 === 1">
                                        <v-card-text>Offers</v-card-text>
                                        <v-divider></v-divider>
                                        <v-list style="height:59vh; overflow-y:auto">

                                            <v-list-item
                                                    v-for="item in items"
                                                    :key="item.title"
                                                    link
                                                    @click="taskerdialog(item.title,item.price,item.avatar)"

                                            >
                                                <v-list-item-avatar>
                                                    <v-img :src="item.avatar"></v-img>
                                                </v-list-item-avatar>

                                                <v-list-item-content>
                                                    <v-list-item-title v-text="item.title"></v-list-item-title>
                                                    <v-spacer></v-spacer>
                                                    <v-list-item-title v-text="item.time"></v-list-item-title>
                                                    <v-spacer></v-spacer>
                                                    <v-list-item-title v-text="item.price"></v-list-item-title>
                                                </v-list-item-content>

                                            </v-list-item>

                                        </v-list>
                                    </v-card>
                                    <v-card v-else height="70vh" width="30vw" style="background-color: rgba(0,0,0,0.5);">
                                        <v-card-text>Offers</v-card-text>
                                        <v-divider></v-divider>
                                        <v-card-text class="text-lg-center font-weight-bold white--text mt-12 justify-lg-center" style="font-size: x-large">You have accepted an offer</v-card-text>
                                    </v-card>
                                </v-col>

                                <v-col cols="12" lg="4">
                                    <v-dialog v-model="paydialog" width="500px" height="50vh">
                                        <v-card
                                                height="20vh"
                                        >
                                            Please Wait until the Payement is completed:
                                            <v-progress-circular
                                                    :rotate="360"
                                                    :size="90"
                                                    :width="15"
                                                    :value="value"
                                                    color="#7cfc00"
                                            >
                                                {{ value }}
                                            </v-progress-circular>
                                        </v-card>

                                    </v-dialog>
                                    <v-card height="70vh" width="50vw" v-if="e1 === 2">
                                        <v-card-text>Payement</v-card-text>
                                        <v-divider></v-divider>
                                        <v-container v-if="payed" class="align-content-center light-green--text">Transaction completed successfully
                                            <br>
                                        </v-container>
                                        <v-container v-if="payed">
                                            <p style="font-size: large; text-decoration-color: black; font-family: Arial, sans-serif;">Thank you for your purchase. We have received your
                                                payment for Task #13201. Best Ways Shop.</p>
                                            <v-btn color="#7cfc00" outlined @click="lastlevel()">Admitted</v-btn>
                                            <v-btn color="red" outlined class="ml-2">This payement is wrong</v-btn>
                                        </v-container>
                                        <v-divider></v-divider>
                                        <v-container>
                                            <p style="font-size: large;" class="text--lighten-2 grey--text">Registered Card</p>
                                                <v-img src="https://www.pngitem.com/pimgs/m/491-4916183_green-motif-icbc-visa-debit-card-hd-png.png">
                                                </v-img>
                                        </v-container>
                                    </v-card>

                                    <v-card v-else height="70vh" width="30vw" style="background-color: rgba(0,0,0,0.5);">
                                        <v-card-text>Payement</v-card-text>
                                        <v-divider></v-divider>
                                        <v-card-text class="text-lg-center font-weight-bold white--text mt-12 justify-lg-center" style="font-size: x-large">{{payementmessage}}</v-card-text>
                                    </v-card>


                                </v-col>

                                <v-col cols="12" lg="4">
                                    <v-card height="70vh" width="60vw" v-if="e1 === 3">
                                        <v-card-text>Task State</v-card-text>
                                        <v-divider></v-divider>
                                        <v-container>
                                            <v-btn outlined color="success" @click="done()" class="ml-5 mb-5">The task is finished</v-btn>
                                            <v-divider></v-divider>
                                            <v-card class="mt-12" flat>
                                            <v-progress-circular
                                                    size="200"
                                                    :value="valuetaskee"
                                                    color="#7cfc00"
                                                    style="margin-left: 15vh;"
                                            >{{ valuetaskee }}</v-progress-circular>
                                            <v-text-field
                                                    v-model="valuetaskee"
                                                    class="mx-4"
                                                    hint="increases or reduces the task progress by 10 percent"
                                                    label="Task Progress"
                                                    max="100"
                                                    min="0"
                                                    step="10"
                                                    style="width: 200px; margin-left: 15vh;"
                                                    type="number"
                                                    color="#7cfc00"
                                                    @keydown="false"
                                            ></v-text-field>
                                            </v-card>
                                        </v-container>
                                    </v-card>
                                    <v-card v-else height="70vh" width="30vw" style="background-color: rgba(0,0,0,0.5);">
                                        <v-card-text>Task State</v-card-text>
                                        <v-divider></v-divider>
                                        <v-card-text class="text-lg-center font-weight-bold white--text mt-12 justify-lg-center" style="font-size: x-large">{{starttask}}</v-card-text>

                                    </v-card>
                                </v-col>
                                <v-spacer></v-spacer>
                                <v-btn outlined to="/task" color="success">Back to tasks List</v-btn>
                            </v-row>
                            </v-container>
                        </v-container>
                        <v-container v-else fluid>
                            <v-container fluid>
                                <v-card width="79vw" height="20vh" style="background-color: rgba(0,0,0,0.5)">
                                    <v-card-text>
                                        <span style="font-size: xx-large; margin-left: 30vw; margin-top: 10vh;" class="white--text">The task is finished</span>
                                    </v-card-text>
                                </v-card>
                            </v-container>
                            <v-btn outlined to="/task" color="success" class="ml-4">Back to tasks List</v-btn>
                        </v-container>
                    </v-flex>
                </v-layout>
            </v-content>
        </v-app>
    </template>

    <script>
        import Toolbar from "./toolbar";
        import Navbar from "./navbar";
        //import Tasktable from "./tasktable";
        import pattern from "../assets/Mask_Group_1_mw_pattern.png"
        export default {
            name: "eachtask",
            components: {Navbar, Toolbar},
            props: {
                taskid: Number,
            },
            data () {
                return{
                    payementmessage: '',
                    starttask:'',
                    valuetaskee: 0,
                    pattern: pattern,
                    e1: 1,
                    payed: false,
                    n: 1,
                    dates: null,
                    click: 0,
                    paydialog: false,
                    taskername: '',
                    taskerprice: '',
                    taskeravatar: '',
                    taskdefinition: 0,
                    taskdescription: null,
                    subcategory: null,
                    taskname: null,
                    taskcategory: null,
                    dialog: false,
                    complete: ['true','False','False','False'],
                    categories: ['task1', 'task2', 'task3'],
                    regions: ['region1', 'region2'],
                    value: 0,
                    rules: {
                        required: value => !!value || 'Required.',
                    },
                    items: [
                        { active: true, title: 'Jason Oner', avatar: 'https://cdn.vuetifyjs.com/images/lists/1.jpg',time: "10 min ago", price: "10$/h" },
                        { active: true, title: 'Ranee Carlson', avatar: 'https://cdn.vuetifyjs.com/images/lists/2.jpg', time: "10 min ago", price: "10$/h" },
                        { title: 'Cindy Baker', avatar: 'https://cdn.vuetifyjs.com/images/lists/3.jpg', time: "10 min ago", price: "10$/h" },
                        { title: 'Ali Connors', avatar: 'https://cdn.vuetifyjs.com/images/lists/4.jpg', time: "10 min ago", price: "10$/h" },
                        { active: true, title: 'Ranee Carlson', avatar: 'https://cdn.vuetifyjs.com/images/lists/2.jpg', time: "10 min ago", price: "10$/h" },
                        { title: 'Cindy Baker', avatar: 'https://cdn.vuetifyjs.com/images/lists/3.jpg', time: "10 min ago", price: "10$/h" },
                        { title: 'Ali Connors', avatar: 'https://cdn.vuetifyjs.com/images/lists/4.jpg', time: "10 min ago", price: "10$/h" },
                        { active: true, title: 'Ranee Carlson', avatar: 'https://cdn.vuetifyjs.com/images/lists/2.jpg', time: "10 min ago", price: "10$/h" },
                        { title: 'Cindy Baker', avatar: 'https://cdn.vuetifyjs.com/images/lists/3.jpg', time: "10 min ago", price: "10$/h" },
                        { title: 'Ali Connors', avatar: 'https://cdn.vuetifyjs.com/images/lists/4.jpg', time: "10 min ago", price: "10$/h" },
                        { active: true, title: 'Ranee Carlson', avatar: 'https://cdn.vuetifyjs.com/images/lists/2.jpg', time: "10 min ago", price: "10$/h" },
                        { title: 'Cindy Baker', avatar: 'https://cdn.vuetifyjs.com/images/lists/3.jpg', time: "10 min ago", price: "10$/h" },
                        { title: 'Ali Connors', avatar: 'https://cdn.vuetifyjs.com/images/lists/4.jpg', time: "10 min ago", price: "10$/h" },


                    ],
                }
            },
            beforeDestroy () {
                console.log("in hereee");
            },
            methods: {
                addfunc() {
                    this.e1 = this.e1 + 1;
                    console.log(this.e1);
                    this.dialog = false;
                    this.paydialog = true;
                    this.interval = setInterval(() => {
                        if (this.value === 100) {
                            this.payed = true;
                            this.paydialog = false;
                        }
                        this.value += 10
                    }, 1000);
                    this.$store.commit('updatetaskstatus', {taskid: this.taskid, status: this.e1})

                },
                taststatus() {
                    console.log("in taskid = 1");
                    console.log(this.$store.state.tasks[this.taskid - 1].e1);
                    this.e1 = this.$store.state.tasks[this.taskid - 1].e1;
                },
                taskerdialog(name, price, avatar) {
                    this.dialog = true;
                    this.taskername = name;
                    this.taskerprice = price;
                    this.taskeravatar = avatar;

                },
                lastlevel(){
                    this.e1 = this.e1 + 1;
                    this.payementmessage = 'Paymenet is Done successfully';
                    this.$store.commit('updatetaskstatus', {taskid: this.taskid, status: this.e1});

                },
                done(){
                    this.e1 = this.e1 + 1;
                    this.starttask = 'The task is finished';
                    this.$store.commit('updatetaskstatus', {taskid: this.taskid, status: this.e1});

                }
            },
            mounted() {
                this.taststatus();
                this.payementmessage = 'No payement yet';
                this.starttask = 'Task is not started yet'
            },

        }
    </script>

    <style scoped>
        .buttoncolor{
            color: #7cfc00;
        }
    </style>

