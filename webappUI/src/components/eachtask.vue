 <template>
        <v-app class="grey lighten-5">
            <v-content>
                <toolbar></toolbar>
                <v-layout row>
                    <v-flex lg2>
                        <navbar></navbar>
                    </v-flex>
                    <v-flex lg10>
                        <v-container width="120vw" fluid>
                            <v-container class="ml-0 mt-2 mb-6 mr-0">
                                <span class="text-lg-left font-weight-bold font-weight-black" style="font-size: xx-large">Task</span>
                            </v-container>
                            <v-container fluid>
                                <v-card width="79vw" height="20vh">
                                    <v-card-text class="font-weight-bold font-weight-black">Task Status Bar</v-card-text>

                                    <v-card flat style="margin-left: 80px; margin-right: 80px;">

                                        <v-stepper alt-labels v-model="e1" style="box-shadow: none;" class="mr-12 ml-12">
                                            <v-stepper-header>
                                                <v-stepper-step step="1" color="#7cfc00" :complete="e1 > 1" >Definition</v-stepper-step>
                                                <v-divider></v-divider>
                                                <v-stepper-step step="2" color="#7cfc00" :complete="e1 > 2">Offers</v-stepper-step>
                                                <v-divider></v-divider>
                                                <v-stepper-step step="3" color="#7cfc00" :complete="e1 > 3">Payement</v-stepper-step>
                                                <v-divider></v-divider>
                                                <v-stepper-step step="4" color="#7cfc00" :complete="e1 > 4">status</v-stepper-step>
                                            </v-stepper-header>
                                        </v-stepper>
                                    </v-card>
                                </v-card>
                            </v-container>
                            <v-row class="mr-4 ml-1">
                                <v-col cols="12" lg="4">
                                    <v-card height="65vh" width="30vw">
                                        <v-card-text>Offers</v-card-text>
                                        <v-divider></v-divider>
                                        <v-list style="height:59vh; overflow-y:auto">
                                            <v-dialog v-model="dialog">
                                                <v-card height="10vh"></v-card>
                                            </v-dialog>
                                            <v-list-item
                                                    v-for="item in items"
                                                    :key="item.title"
                                                    link
                                                    @click="dialog = true"

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
                                </v-col>

                                <v-col cols="12" lg="4">
                                    <v-card height="65vh" width="50vw">
                                        <v-card-text>Payement</v-card-text>
                                        <v-divider></v-divider>
                                        <v-container class="align-content-center light-green--text">Transaction completed successfully
                                            <br>
                                        </v-container>
                                        <v-container>
                                            <p style="font-size: large; text-decoration-color: black; font-family: Arial, sans-serif;">Thank you for your purchase. We have received your
                                                payment for Task #13201. Best Ways Shop.</p>
                                        </v-container>
                                        <v-divider></v-divider>
                                        <v-container>
                                            <p style="font-size: large;" class="text--lighten-2 grey--text">Registered Card</p>
                                            <v-card height="20vh" width="60vh" style="background-color: limegreen;" class="mt-10">
                                            </v-card>
                                        </v-container>
                                    </v-card>
                                </v-col>

                                <v-col cols="12" lg="4">
                                    <v-card height="65vh" width="60vw">
                                        <v-card-text>Task State</v-card-text>
                                        <v-divider></v-divider>
                                    </v-card>
                                </v-col>

                            </v-row>
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

        export default {
            name: "eachtask",
            components: {Navbar, Toolbar},
            props: {
                taskid: Number,
            },
            data () {
                return {
                    e1: 1,
                    n: 1,
                    dates: null,
                    click: 0,
                    taskdefinition: 0,
                    taskdescription: null,
                    subcategory: null,
                    taskname: null,
                    taskcategory: null,
                    dialog: false,
                    complete: ['true','False','False','False'],
                    categories: ['task1', 'task2', 'task3'],
                    regions: ['region1', 'region2'],
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
            methods: {
                addfunc() {
                    this.e1 = this.e1 + 1;
                    console.log(this.e1);
                    this.$store.commit('updatetaskstatus', {taskid: this.taskid, status: this.e1})

                },
                taststatus() {
                    console.log("in taskid = 1");
                    console.log(this.$store.state.tasks[this.taskid - 1].e1);
                    this.e1 = this.$store.state.tasks[this.taskid - 1].e1;
                }
            },
            mounted() {
                this.taststatus();
            }

        }
    </script>

    <style scoped>
        .buttoncolor{
            color: #7cfc00;
        }
    </style>

