$(function () {
    var l = abp.localization.getResource('');
    var createModal = new abp.ModalManager(abp.appPath + 'Units/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'Units/EditModal');

    var dataTable = $('#UnitsTable').DataTable(
        abp.libs.datatables.normalizeConfiguration({
            serverSide: true,
            paging: true,
            order: [[1, "desc"]],
            searching: true,
            scrollX: true,
            ajax: abp.libs.datatables.createAjax(marketVegetables.units.unit.getList),
            columnDefs: [
                {
                    title: l('Actions'),
                    rowAction: {
                        items:
                            [
                                {
                                    text: l('Edit'),
                                    action: function (data) {
                                        editModal.open({ id: data.record.id });
                                    }
                                },
                                {
                                    text: l('Delete'),
                                    confirmMessage: function (data) {
                                        return l(
                                            'AuthorDeletionConfirmationMessage',
                                            data.record.name
                                        );
                                    },
                                    action: function (data) {
                                        marketVegetables.Units.category
                                            .delete(data.record.id)
                                            .then(function () {
                                                abp.notify.info(
                                                    l('SuccessfullyDeleted')
                                                );
                                                dataTable.ajax.reload();
                                            });
                                    }
                                }
                            ]
                    }
                },
                {
                    title: l('Unit Id'),
                    data: "id",

                },
                {
                    title: l('Unit Name'),
                    data: "unitName"
                },
                {
                    title: l('Creation Time'), data: "creationTime",
                    render: function (data) {
                        return luxon
                            .DateTime
                            .fromISO(data, {
                                locale: abp.localization.currentCulture.name
                            }).toLocaleString(luxon.DateTime.DATETIME_SHORT);
                    }
                }
            ]
        })
    );
    createModal.onResult(function () {
        dataTable.ajax.reload();
    });

    editModal.onResult(function () {
        dataTable.ajax.reload();
    });

    $('#NewUnitButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});
