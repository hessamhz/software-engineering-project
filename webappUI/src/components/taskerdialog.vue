<template>
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
</template>

<script>
    export default {
        name: "taskerdialog"
    }
</script>

<style scoped>

</style>